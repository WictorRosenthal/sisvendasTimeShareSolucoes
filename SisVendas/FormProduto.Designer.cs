namespace SisVendas
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            button2 = new Button();
            button1 = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            cbxCategoria = new ComboBox();
            label2 = new Label();
            nudPreco = new NumericUpDown();
            label3 = new Label();
            nudQtdEstoque = new NumericUpDown();
            label4 = new Label();
            nudQtdMinimaEmEstoque = new NumericUpDown();
            label5 = new Label();
            rtbDescricao = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQtdEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQtdMinimaEmEstoque).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(335, 192);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(254, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Novo Produto";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(255, 27);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(165, 23);
            cbxCategoria.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 7);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Categoria";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(15, 82);
            nudPreco.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 64);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Preço";
            // 
            // nudQtdEstoque
            // 
            nudQtdEstoque.Location = new Point(15, 139);
            nudQtdEstoque.Name = "nudQtdEstoque";
            nudQtdEstoque.Size = new Size(120, 23);
            nudQtdEstoque.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 121);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 13;
            label4.Text = "Quantidade Estoque";
            // 
            // nudQtdMinimaEmEstoque
            // 
            nudQtdMinimaEmEstoque.Location = new Point(15, 192);
            nudQtdMinimaEmEstoque.Name = "nudQtdMinimaEmEstoque";
            nudQtdMinimaEmEstoque.Size = new Size(120, 23);
            nudQtdMinimaEmEstoque.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 174);
            label5.Name = "label5";
            label5.Size = new Size(178, 15);
            label5.TabIndex = 15;
            label5.Text = "Quantidade mínima em Estoque";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(174, 81);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(246, 81);
            rtbDescricao.TabIndex = 6;
            rtbDescricao.Text = "Descrição";
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 233);
            ControlBox = false;
            Controls.Add(rtbDescricao);
            Controls.Add(label5);
            Controls.Add(nudQtdMinimaEmEstoque);
            Controls.Add(label4);
            Controls.Add(nudQtdEstoque);
            Controls.Add(label3);
            Controls.Add(nudPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Produto";
        
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQtdEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQtdMinimaEmEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        public TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public ComboBox cbxCategoria;
        public NumericUpDown nudPreco;
        public NumericUpDown nudQtdEstoque;
        public NumericUpDown nudQtdMinimaEmEstoque;
        public RichTextBox rtbDescricao;
    }
}