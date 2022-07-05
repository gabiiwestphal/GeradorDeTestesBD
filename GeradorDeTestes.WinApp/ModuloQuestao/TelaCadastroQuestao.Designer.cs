namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class TelaCadastroQuestao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMateria = new System.Windows.Forms.Label();
            this.comboBoxMaterias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAlternativas = new System.Windows.Forms.GroupBox();
            this.btnExcluirAlternativa = new System.Windows.Forms.Button();
            this.listAlternativas = new System.Windows.Forms.ListBox();
            this.btnAddAlternativa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoAlternativa = new System.Windows.Forms.TextBox();
            this.comboBoxLetraAlternativa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDisciplinas = new System.Windows.Forms.ComboBox();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.comboBoxAlternativaCorreta = new System.Windows.Forms.ComboBox();
            this.groupBoxAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMateria
            // 
            this.txtMateria.AutoSize = true;
            this.txtMateria.Location = new System.Drawing.Point(16, 65);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(63, 20);
            this.txtMateria.TabIndex = 0;
            this.txtMateria.Text = "Matéria:";
            // 
            // comboBoxMaterias
            // 
            this.comboBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterias.FormattingEnabled = true;
            this.comboBoxMaterias.Location = new System.Drawing.Point(102, 61);
            this.comboBoxMaterias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMaterias.Name = "comboBoxMaterias";
            this.comboBoxMaterias.Size = new System.Drawing.Size(266, 28);
            this.comboBoxMaterias.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enunciado: ";
            // 
            // groupBoxAlternativas
            // 
            this.groupBoxAlternativas.Controls.Add(this.btnExcluirAlternativa);
            this.groupBoxAlternativas.Controls.Add(this.listAlternativas);
            this.groupBoxAlternativas.Controls.Add(this.btnAddAlternativa);
            this.groupBoxAlternativas.Controls.Add(this.label3);
            this.groupBoxAlternativas.Controls.Add(this.txtDescricaoAlternativa);
            this.groupBoxAlternativas.Controls.Add(this.comboBoxLetraAlternativa);
            this.groupBoxAlternativas.Controls.Add(this.label1);
            this.groupBoxAlternativas.Location = new System.Drawing.Point(24, 204);
            this.groupBoxAlternativas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAlternativas.Name = "groupBoxAlternativas";
            this.groupBoxAlternativas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAlternativas.Size = new System.Drawing.Size(538, 393);
            this.groupBoxAlternativas.TabIndex = 5;
            this.groupBoxAlternativas.TabStop = false;
            this.groupBoxAlternativas.Text = "Alternativas";
            // 
            // btnExcluirAlternativa
            // 
            this.btnExcluirAlternativa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirAlternativa.Location = new System.Drawing.Point(392, 354);
            this.btnExcluirAlternativa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirAlternativa.Name = "btnExcluirAlternativa";
            this.btnExcluirAlternativa.Size = new System.Drawing.Size(137, 31);
            this.btnExcluirAlternativa.TabIndex = 8;
            this.btnExcluirAlternativa.Text = "Excluir Alternativa";
            this.btnExcluirAlternativa.UseVisualStyleBackColor = true;
            this.btnExcluirAlternativa.Click += new System.EventHandler(this.btnExcluirAlternativa_Click);
            // 
            // listAlternativas
            // 
            this.listAlternativas.FormattingEnabled = true;
            this.listAlternativas.ItemHeight = 20;
            this.listAlternativas.Location = new System.Drawing.Point(10, 140);
            this.listAlternativas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAlternativas.Name = "listAlternativas";
            this.listAlternativas.Size = new System.Drawing.Size(519, 204);
            this.listAlternativas.TabIndex = 7;
            // 
            // btnAddAlternativa
            // 
            this.btnAddAlternativa.Location = new System.Drawing.Point(13, 77);
            this.btnAddAlternativa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAlternativa.Name = "btnAddAlternativa";
            this.btnAddAlternativa.Size = new System.Drawing.Size(516, 31);
            this.btnAddAlternativa.TabIndex = 6;
            this.btnAddAlternativa.Text = "Adicionar Alternativa";
            this.btnAddAlternativa.UseVisualStyleBackColor = true;
            this.btnAddAlternativa.Click += new System.EventHandler(this.btnAddAlternativa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricaoAlternativa
            // 
            this.txtDescricaoAlternativa.Location = new System.Drawing.Point(217, 42);
            this.txtDescricaoAlternativa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricaoAlternativa.Name = "txtDescricaoAlternativa";
            this.txtDescricaoAlternativa.Size = new System.Drawing.Size(312, 27);
            this.txtDescricaoAlternativa.TabIndex = 2;
            // 
            // comboBoxLetraAlternativa
            // 
            this.comboBoxLetraAlternativa.DropDownHeight = 60;
            this.comboBoxLetraAlternativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLetraAlternativa.DropDownWidth = 35;
            this.comboBoxLetraAlternativa.FormattingEnabled = true;
            this.comboBoxLetraAlternativa.IntegralHeight = false;
            this.comboBoxLetraAlternativa.ItemHeight = 20;
            this.comboBoxLetraAlternativa.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxLetraAlternativa.Location = new System.Drawing.Point(56, 40);
            this.comboBoxLetraAlternativa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLetraAlternativa.Name = "comboBoxLetraAlternativa";
            this.comboBoxLetraAlternativa.Size = new System.Drawing.Size(57, 28);
            this.comboBoxLetraAlternativa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letra: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alternativa Correta: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(476, 639);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(384, 639);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(86, 40);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disciplina: ";
            // 
            // comboBoxDisciplinas
            // 
            this.comboBoxDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplinas.FormattingEnabled = true;
            this.comboBoxDisciplinas.Location = new System.Drawing.Point(102, 17);
            this.comboBoxDisciplinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDisciplinas.Name = "comboBoxDisciplinas";
            this.comboBoxDisciplinas.Size = new System.Drawing.Size(266, 28);
            this.comboBoxDisciplinas.TabIndex = 11;
            this.comboBoxDisciplinas.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplinas_SelectedIndexChanged);
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(102, 106);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(438, 77);
            this.txtEnunciado.TabIndex = 12;
            // 
            // comboBoxAlternativaCorreta
            // 
            this.comboBoxAlternativaCorreta.DropDownHeight = 60;
            this.comboBoxAlternativaCorreta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlternativaCorreta.DropDownWidth = 35;
            this.comboBoxAlternativaCorreta.FormattingEnabled = true;
            this.comboBoxAlternativaCorreta.IntegralHeight = false;
            this.comboBoxAlternativaCorreta.ItemHeight = 20;
            this.comboBoxAlternativaCorreta.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxAlternativaCorreta.Location = new System.Drawing.Point(166, 624);
            this.comboBoxAlternativaCorreta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAlternativaCorreta.Name = "comboBoxAlternativaCorreta";
            this.comboBoxAlternativaCorreta.Size = new System.Drawing.Size(57, 28);
            this.comboBoxAlternativaCorreta.TabIndex = 13;
            // 
            // TelaCadastroQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 695);
            this.Controls.Add(this.comboBoxAlternativaCorreta);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDisciplinas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBoxAlternativas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMaterias);
            this.Controls.Add(this.txtMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroQuestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Questão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroQuestao_FormClosing);
            this.Load += new System.EventHandler(this.TelaCadastroQuestao_Load);
            this.groupBoxAlternativas.ResumeLayout(false);
            this.groupBoxAlternativas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMateria;
        private System.Windows.Forms.ComboBox comboBoxMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAlternativas;
        private System.Windows.Forms.Button btnAddAlternativa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoAlternativa;
        private System.Windows.Forms.ComboBox comboBoxLetraAlternativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDisciplinas;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.ListBox listAlternativas;
        private System.Windows.Forms.ComboBox comboBoxAlternativaCorreta;
        private System.Windows.Forms.Button btnExcluirAlternativa;
    }
}