using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Infra.BancoDeDados.ModuloDisciplina;
using GeradorDeTestes.Infra.BancoDeDados.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.Infra.Banco_de_Dados
{
    public class RepositorioQuestaoEmBancoDeDados : IRepositorioQuestao
    {

        RepositorioDisciplinaEmBancoDeDados repositorioDisciplina = new RepositorioDisciplinaEmBancoDeDados();
        RepositorioMateriaEmBancoDeDados repositorioMateria = new RepositorioMateriaEmBancoDeDados();


        private const string enderecoBanco =
                "Data Source=(LocalDb)\\MSSQLLocalDB;" +
                "Initial Catalog=TestesAleatoriosDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

        #region SQL Queries
        private const string sqlInserir =
           @"INSERT INTO [TBQUESTAO] 
                (
                    [ENUNCIADO],
                    [RESPOSTA],
                    [MATERIA_NUMERO],
                    [DISCIPLINA_NUMERO]
                )
	            VALUES
                (
                    @ENUNCIADO,
                    @RESPOSTA,
                    @MATERIA_NUMERO,
                    @DISCIPLINA_NUMERO
                );SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
            @"UPDATE [TBQUESTAO]	
		        SET
			        [ENUNCIADO] = @ENUNCIADO,
			        [RESPOSTA] = @RESPOSTA,
                    [MATERIA_NUMERO] = @MATERIA_NUMERO,
                    [DISCIPLINA_NUMERO] = @DISCIPLINA_NUMERO
		        WHERE
			        [NUMERO] = @NUMERO";

        private const string sqlExcluir =
            @"DELETE FROM [TBALTERNATIVA]
                WHERE
                    [QUESTAO_NUMERO] = @NUMERO;
              DELETE FROM [TBTESTE_QUESTAO]
                WHERE
                    [QUESTAO_NUMERO] = @NUMERO;
              DELETE FROM [TBQUESTAO]
                WHERE
                    [NUMERO] = @NUMERO";

        private const string sqlSelecionarPorNumero =
           @"SELECT
	                Q.NUMERO,
                    Q.ENUNCIADO,
                    Q.RESPOSTA,
                    D.NUMERO AS DISCIPLINA_NUMERO,
                    D.NOME AS DISCIPLINA_NOME,
                    M.NUMERO AS MATERIA_NUMERO,
                    M.NOME AS MATERIA_NOME
                FROM 
	                TBQUESTAO AS Q INNER JOIN TBDISCIPLINA AS D ON
                    Q.DISCIPLINA_NUMERO = D.NUMERO
                        INNER JOIN TBMATERIA AS M ON
                        Q.MATERIA_NUMERO = M.NUMERO
                WHERE
                    Q.NUMERO = @NUMERO";

        private const string sqlSelecionarTodos =
           @"SELECT
	                Q.NUMERO,
                    Q.ENUNCIADO,
                    Q.RESPOSTA,
                    D.NUMERO AS DISCIPLINA_NUMERO,
                    D.NOME AS DISCIPLINA_NOME,
                    M.NUMERO AS MATERIA_NUMERO,
                    M.NOME AS MATERIA_NOME
              FROM 
	                TBQUESTAO AS Q INNER JOIN TBDISCIPLINA AS D ON
                    Q.DISCIPLINA_NUMERO = D.NUMERO
                        INNER JOIN TBMATERIA AS M ON
                        Q.MATERIA_NUMERO = M.NUMERO";

        private const string sqlInserirAlternativa =
            @"INSERT INTO [TBALTERNATIVA]
                (
		            [LETRA],
		            [DESCRICAO],
                    [QUESTAO_NUMERO]
	            )
                 VALUES
                (
		            @LETRA,
		            @DESCRICAO,
                    @QUESTAO_NUMERO
	            ); SELECT SCOPE_IDENTITY();";


        private const string sqlExcluirAlternativa =
            @"DELETE FROM [TBALTERNATIVA]
		        WHERE
			        [QUESTAO_NUMERO] = @QUESTAO_NUMERO";

        private const string sqlSelecionarAlternativas =
            @"SELECT
                    [NUMERO],
		            [LETRA],
		            [DESCRICAO],
                    [QUESTAO_NUMERO]

                FROM TBALTERNATIVA

                WHERE
                    [QUESTAO_NUMERO] = @QUESTAO_NUMERO
                ";

        #endregion

        public void AdicionarAlternativas(Questao questaoSelecionada, List<Alternativa> alternativas)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            foreach (var item in alternativas)
            {
                if (item.Numero > 0)
                    continue;

                item.Numero_Questao = questaoSelecionada.Numero;
                questaoSelecionada.AdicionarAlternativa(item);

                SqlCommand comandoInsercao = new SqlCommand(sqlInserirAlternativa, conexaoComBanco);

                ConfigurarParametrosAlternativas(item, comandoInsercao);
                var id = comandoInsercao.ExecuteScalar();
                item.Numero = Convert.ToInt32(id);
            }

            conexaoComBanco.Close();

            Editar(questaoSelecionada);
        }

        public ValidationResult Editar(Questao questao)
        {
            var validador = new ValidadorQuestao();

            var resultadoValidacao = validador.Validate(questao);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            ConfigurarParametrosQuestao(questao, comandoEdicao);

            conexaoComBanco.Open();
            comandoEdicao.ExecuteNonQuery();

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Questao questao)
        {
            ExcluirAlternativasQuestao(questao);

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("NUMERO", questao.Numero);

            conexaoComBanco.Open();
            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Inserir(Questao novaQuestao)
        {
            var validador = new ValidadorQuestao();

            var resultadoValidacao = validador.Validate(novaQuestao);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosQuestao(novaQuestao, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
            novaQuestao.Numero = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public Questao SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorTarefa = comandoSelecao.ExecuteReader();

            Questao questao = null;

            if (leitorTarefa.Read())
                questao = ConverterParaQuestao(leitorTarefa);

            conexaoComBanco.Close();

            CarregarAlternativas(questao);

            return questao;
        }

        public List<Questao> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();
            SqlDataReader leitorQuestao = comandoSelecao.ExecuteReader();

            List<Questao> questoes = new List<Questao>();

            while (leitorQuestao.Read())
            {
                Questao questao = ConverterParaQuestao(leitorQuestao);

                questoes.Add(questao);
            }

            conexaoComBanco.Close();

            return questoes;
        }

        public List<Questao> Sortear(Materia materia, int qtd)
        {
            int limite = 0;
            List<Questao> questoesSorteadas = new List<Questao>();
            List<Questao> questoesMateriaSelecionada = SelecionarTodos().Where(x => x.Materia.Nome.Equals(materia.Nome)).ToList();

            Random rdm = new Random();
            List<Questao> questoes = questoesMateriaSelecionada.OrderBy(item => rdm.Next()).ToList();

            foreach (Questao q in questoes)
            {
                questoesSorteadas.Add(q);
                limite++;
                if (limite == qtd)
                    break;
            }


            return questoesSorteadas;
        }

        public List<Questao> SortearQuestoesRecuperacao(Disciplina disciplina, int qtd)
        {
            int limite = 0;
            List<Questao> questoesSorteadas = new List<Questao>();
            List<Questao> questoesDisciplinaSelecionada = SelecionarTodos().Where(x => x.Disciplina.Nome.Equals(disciplina.Nome)).ToList();

            Random rdm = new Random();
            List<Questao> questoes = questoesDisciplinaSelecionada.OrderBy(item => rdm.Next()).ToList();

            foreach (Questao q in questoes)
            {
                questoesSorteadas.Add(q);
                limite++;
                if (limite == qtd)
                    break;
            }

            return questoesSorteadas;
        }

        #region Métodos privados
        private void ConfigurarParametrosAlternativas(Alternativa item, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", item.Numero);
            comando.Parameters.AddWithValue("LETRA", item.Letra);
            comando.Parameters.AddWithValue("DESCRICAO", item.Descricao);
            comando.Parameters.AddWithValue("QUESTAO_NUMERO", item.Numero_Questao);
        }

        private void ConfigurarParametrosQuestao(Questao questao, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", questao.Numero);
            comando.Parameters.AddWithValue("ENUNCIADO", questao.Enunciado);
            comando.Parameters.AddWithValue("RESPOSTA", questao.Resposta);
            comando.Parameters.AddWithValue("MATERIA_NUMERO", questao.Materia.Numero);
            comando.Parameters.AddWithValue("DISCIPLINA_NUMERO", questao.Disciplina.Numero);
        }

        private Questao ConverterParaQuestao(SqlDataReader leitorQuestao)
        {
            var numero = Convert.ToInt32(leitorQuestao["NUMERO"]);
            var enunciado = Convert.ToString(leitorQuestao["ENUNCIADO"]);
            var resposta = Convert.ToChar(leitorQuestao["RESPOSTA"]);
            var numeroMateria = Convert.ToInt32(leitorQuestao["MATERIA_NUMERO"]);
            var numeroDisciplina = Convert.ToInt32(leitorQuestao["DISCIPLINA_NUMERO"]);

            var questao = new Questao
            {
                Numero = numero,
                Enunciado = enunciado,
                Resposta = resposta,
                Materia = repositorioMateria.SelecionarPorNumero(numeroMateria),
                Disciplina = repositorioDisciplina.SelecionarPorNumero(numeroDisciplina)
            };

            return questao;
        }

        private void ExcluirAlternativasQuestao(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluirAlternativa, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("QUESTAO_NUMERO", questao.Numero);

            conexaoComBanco.Open();
            comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void CarregarAlternativas(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarAlternativas, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("QUESTAO_NUMERO", questao.Numero);

            conexaoComBanco.Open();
            SqlDataReader leitorAlternativasQuestao = comandoSelecao.ExecuteReader();


            while (leitorAlternativasQuestao.Read())
            {
                Alternativa alternativa = ConverterParaAlternativa(leitorAlternativasQuestao);

                questao.AdicionarAlternativa(alternativa);
            }

            conexaoComBanco.Close();
        }

        private Alternativa ConverterParaAlternativa(SqlDataReader leitorAlternativas)
        {
            var numero = Convert.ToInt32(leitorAlternativas["NUMERO"]);
            var letra = Convert.ToString(leitorAlternativas["LETRA"]);
            var descricao = Convert.ToString(leitorAlternativas["DESCRICAO"]);
            var numero_questao = Convert.ToInt32(leitorAlternativas["QUESTAO_NUMERO"]);

            var alternativa = new Alternativa
            {
                Numero = numero,
                Letra = letra,
                Descricao = descricao,
                Numero_Questao = numero_questao
            };

            return alternativa;
        }

        #endregion
    }
}
