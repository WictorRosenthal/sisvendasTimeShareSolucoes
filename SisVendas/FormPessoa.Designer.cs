namespace SisVendas
{
    partial class FormPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoa));
            txtNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            mtbCpfCnpj = new MaskedTextBox();
            label4 = new Label();
            txtApelido = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(351, 23);
            txtNome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 21);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "CPF";
            // 
            // mtbCpfCnpj
            // 
            mtbCpfCnpj.Location = new Point(369, 39);
            mtbCpfCnpj.Mask = "000,000,000-00";
            mtbCpfCnpj.Name = "mtbCpfCnpj";
            mtbCpfCnpj.Size = new Size(98, 23);
            mtbCpfCnpj.TabIndex = 6;
            mtbCpfCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 11;
            label4.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(12, 93);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(167, 23);
            txtApelido.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(392, 93);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(311, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 141);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(txtApelido);
            Controls.Add(mtbCpfCnpj);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPessoa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Pessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnSalvar;
        private Button btnCancelar;
        public TextBox txtNome;
        public MaskedTextBox mtbCpfCnpj;
        public TextBox txtApelido;
    }
}