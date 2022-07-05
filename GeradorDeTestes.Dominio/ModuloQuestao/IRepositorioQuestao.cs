using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorioBase<Questao>
    {
        void AdicionarAlternativas(Questao q, List<Alternativa> a);
        List<Questao> Sortear(Materia materia, int qtd);
        List<Questao> SortearQuestoesRecuperacao(Disciplina disciplina, int qtd);
    }
}
