using GeradorDeTestes.Dominio.Compartilhado;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string Letra { get; set; }
        public string Descricao { get; set; }
        public int Numero_Questao { get; set; }

        public Alternativa()
        {

        }
                                     
        public Alternativa(string letra, string descricao) : this()
        {
            Letra = letra;
            Descricao = descricao;
        }


        public override string ToString()
        {
            return $"{Letra}) {Descricao}";
        }

        public override void Atualizar(Alternativa registro)
        {
            throw new System.NotImplementedException();
        }
    }
}