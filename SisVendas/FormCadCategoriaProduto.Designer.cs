namespace SisVendas
{
    partial class FormCadCategoriaProduto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCategoriaProduto));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cbxCategoria = new ComboBox();
            btnAdicionarCategoria = new Button();
            imgListAddEdEx = new ImageList(components);
            btnEditarCategoria = new Button();
            btnExcluirCategoria = new Button();
            btnAdicionarProduto = new Button();
            btnEditarProduto = new Button();
            btnExcluirProduto = new Button();
            dgvProdutos = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clmNome = new DataGridViewTextBoxColumn();
            clmPreco = new DataGridViewTextBoxColumn();
            clmEstoque = new DataGridViewTextBoxColumn();
            clmDescricao = new DataGridViewTextBoxColumn();
            clmQtdMininaEstoque = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 117);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Adicionar Produtos:";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(12, 29);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 0;
            cbxCategoria.SelectedIndexChanged += cbxCategoria_SelectedIndexChanged;
            // 
            // btnAdicionarCategoria
            // 
            btnAdicionarCategoria.ImageIndex = 2;
            btnAdicionarCategoria.ImageList = imgListAddEdEx;
            btnAdicionarCategoria.Location = new Point(139, 29);
            btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            btnAdicionarCategoria.Size = new Size(25, 25);
            btnAdicionarCategoria.TabIndex = 1;
            btnAdicionarCategoria.UseVisualStyleBackColor = true;
            btnAdicionarCategoria.Click += btnAdicionarCategoria_Click;
            // 
            // imgListAddEdEx
            // 
            imgListAddEdEx.ColorDepth = ColorDepth.Depth32Bit;
            imgListAddEdEx.ImageStream = (ImageListStreamer)resources.GetObject("imgListAddEdEx.ImageStream");
            imgListAddEdEx.TransparentColor = Color.Transparent;
            imgListAddEdEx.Images.SetKeyName(0, "bin.png");
            imgListAddEdEx.Images.SetKeyName(1, "pen.png");
            imgListAddEdEx.Images.SetKeyName(2, "plus.png");
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.ImageIndex = 1;
            btnEditarCategoria.ImageList = imgListAddEdEx;
            btnEditarCategoria.Location = new Point(170, 29);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(25, 25);
            btnEditarCategoria.TabIndex = 2;
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnExcluirCategoria
            // 
            btnExcluirCategoria.ImageIndex = 0;
            btnExcluirCategoria.ImageList = imgListAddEdEx;
            btnExcluirCategoria.Location = new Point(202, 29);
            btnExcluirCategoria.Name = "btnExcluirCategoria";
            btnExcluirCategoria.Size = new Size(25, 25);
            btnExcluirCategoria.TabIndex = 3;
            btnExcluirCategoria.UseVisualStyleBackColor = true;
            btnExcluirCategoria.Click += btnExcluirCategoria_Click;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.ImageIndex = 2;
            btnAdicionarProduto.ImageList = imgListAddEdEx;
            btnAdicionarProduto.Location = new Point(471, 113);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(25, 25);
            btnAdicionarProduto.TabIndex = 4;
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.ImageIndex = 1;
            btnEditarProduto.ImageList = imgListAddEdEx;
            btnEditarProduto.Location = new Point(502, 113);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.Size = new Size(25, 25);
            btnEditarProduto.TabIndex = 5;
            btnEditarProduto.UseVisualStyleBackColor = true;
            btnEditarProduto.Click += btnEditarProduto_Click;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.ImageIndex = 0;
            btnExcluirProduto.ImageList = imgListAddEdEx;
            btnExcluirProduto.Location = new Point(533, 114);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(25, 25);
            btnExcluirProduto.TabIndex = 6;
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clmNome, clmPreco, clmEstoque, clmDescricao, clmQtdMininaEstoque });
            dgvProdutos.Location = new Point(12, 145);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(547, 293);
            dgvProdutos.TabIndex = 7;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // clmCodigo
            // 
            clmCodigo.DataPropertyName = "IdProduto";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "D4";
            clmCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            clmCodigo.HeaderText = "idproduto";
            clmCodigo.Name = "clmCodigo";
            clmCodigo.ReadOnly = true;
            clmCodigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmCodigo.Width = 50;
            // 
            // clmNome
            // 
            clmNome.DataPropertyName = "Nome";
            clmNome.HeaderText = "Produto";
            clmNome.Name = "clmNome";
            clmNome.ReadOnly = true;
            clmNome.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPreco
            // 
            clmPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            clmPreco.DefaultCellStyle = dataGridViewCellStyle3;
            clmPreco.HeaderText = "Preço";
            clmPreco.Name = "clmPreco";
            clmPreco.ReadOnly = true;
            clmPreco.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmPreco.Width = 80;
            // 
            // clmEstoque
            // 
            clmEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "D4";
            clmEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            clmEstoque.HeaderText = "Estoque";
            clmEstoque.Name = "clmEstoque";
            clmEstoque.ReadOnly = true;
            clmEstoque.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmEstoque.Width = 80;
            // 
            // clmDescricao
            // 
            clmDescricao.DataPropertyName = "Descricao";
            clmDescricao.HeaderText = "Descrição";
            clmDescricao.Name = "clmDescricao";
            clmDescricao.ReadOnly = true;
            clmDescricao.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmDescricao.Width = 150;
            // 
            // clmQtdMininaEstoque
            // 
            clmQtdMininaEstoque.DataPropertyName = "QtdMinima";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "D4";
            clmQtdMininaEstoque.DefaultCellStyle = dataGridViewCellStyle5;
            clmQtdMininaEstoque.HeaderText = "Qtd Minina Estoque";
            clmQtdMininaEstoque.Name = "clmQtdMininaEstoque";
            clmQtdMininaEstoque.ReadOnly = true;
            clmQtdMininaEstoque.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmQtdMininaEstoque.Width = 80;
            // 
            // FormCadCategoriaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnEditarProduto);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(btnExcluirCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAdicionarCategoria);
            Controls.Add(cbxCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadCategoriaProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormCadCategoriaProduto";
            Load += FormCadCategoriaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxCategoria;
        private Button btnAdicionarCategoria;
        private Button btnEditarCategoria;
        private Button btnExcluirCategoria;
        private Button btnAdicionarProduto;
        private Button btnEditarProduto;
        private Button btnExcluirProduto;
        private DataGridView dgvProdutos;
        private ImageList imgListAddEdEx;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clmNome;
        private DataGridViewTextBoxColumn clmPreco;
        private DataGridViewTextBoxColumn clmEstoque;
        private DataGridViewTextBoxColumn clmDescricao;
        private DataGridViewTextBoxColumn clmQtdMininaEstoque;
    }
}