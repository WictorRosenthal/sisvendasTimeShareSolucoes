namespace SisVendas
{
    partial class FormItens
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
            cbxItensProduto = new ComboBox();
            label1 = new Label();
            dgvItens = new DataGridView();
            btnPesquisarProduto = new Button();
            clmProduto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // cbxItensProduto
            // 
            cbxItensProduto.FormattingEnabled = true;
            cbxItensProduto.Location = new Point(71, 7);
            cbxItensProduto.Name = "cbxItensProduto";
            cbxItensProduto.Size = new Size(362, 23);
            cbxItensProduto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto:";
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AllowUserToResizeColumns = false;
            dgvItens.AllowUserToResizeRows = false;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clmProduto });
            dgvItens.Location = new Point(14, 40);
            dgvItens.Name = "dgvItens";
            dgvItens.Size = new Size(474, 398);
            dgvItens.TabIndex = 2;
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.Image = Properties.Resources.procurar;
            btnPesquisarProduto.Location = new Point(439, 7);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(25, 25);
            btnPesquisarProduto.TabIndex = 3;
            btnPesquisarProduto.UseVisualStyleBackColor = true;
            btnPesquisarProduto.Click += btnPesquisarProduto_Click;
            // 
            // clmProduto
            // 
            clmProduto.DataPropertyName = "Nome";
            clmProduto.HeaderText = "Produto";
            clmProduto.Name = "clmProduto";
            clmProduto.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmProduto.Width = 420;
            // 
            // FormItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(btnPesquisarProduto);
            Controls.Add(dgvItens);
            Controls.Add(label1);
            Controls.Add(cbxItensProduto);
            Name = "FormItens";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Itens";
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxItensProduto;
        private Label label1;
        private DataGridView dgvItens;
        private Button btnPesquisarProduto;
        private DataGridViewTextBoxColumn clmProduto;
    }
}