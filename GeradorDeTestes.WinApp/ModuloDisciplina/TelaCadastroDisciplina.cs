using FluentValidation.Results;
using System;
using System.Windows.Forms;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.WinApp.Compartilhado;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaCadastroDisciplina : Form
    {
        private Disciplina disciplina;
        ValidadorRegex validador = new ValidadorRegex();
        public TelaCadastroDisciplina()
        {
            InitializeComponent();
        }

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get
            {
                return disciplina;
            }
            set
            {
                disciplina = value;
                txtNomeDisciplina.Text = disciplina.Nome;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validador.ApenasLetra(txtNomeDisciplina.Text))
            {
                disciplina.Nome = txtNomeDisciplina.Text;

                var resultadoValidacao = GravarRegistro(disciplina);
                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Insira apenas letras no campo 'Nome'",
                "Cadastro de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;

                return;
            }
        }
        private void TelaCadastroDisciplina_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroDisciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
