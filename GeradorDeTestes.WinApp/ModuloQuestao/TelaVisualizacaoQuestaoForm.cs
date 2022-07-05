using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TelaVisualizacaoQuestaoForm : Form
    {
        private Questao questao;
        public TelaVisualizacaoQuestaoForm(Questao questao)
        {
            InitializeComponent();
            this.questao = questao;
            txtDisciplina.Text = questao.Disciplina.Nome;
            txtMateria.Text = questao.Materia.Nome;
            txtEnunciado.Text = questao.Enunciado;
            CarregarAlternativas();
        }

        private void CarregarAlternativas()
        {
            List<Alternativa> lisAlternativas = questao.Alternativas.ToList();
            List<Alternativa> ordenadas = lisAlternativas.OrderBy(x => x.Letra).ToList();

            foreach (Alternativa a in ordenadas)
            {

                if (a.Letra.Equals(questao.Resposta))
                {
                    checkedListBoxAlternativas.Items.Add(a);
                    int index = checkedListBoxAlternativas.Items.IndexOf(a);
                    checkedListBoxAlternativas.SetItemChecked(index, true);
                }
                else
                    checkedListBoxAlternativas.Items.Add(a);

            }
        }
        
    }
}
