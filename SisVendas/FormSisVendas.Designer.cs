namespace SisVendas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            imgListPedido = new ImageList(components);
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            txtNome = new TextBox();
            label1 = new Label();
            btnAdicionarItenPedido = new Button();
            label2 = new Label();
            cbxClientePedido = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dgvItensSelecionados = new DataGridView();
            groupBox1 = new GroupBox();
            btnExcluirItemPedido = new Button();
            btnAterarItenPedido = new Button();
            label7 = new Label();
            txtEstoque = new TextBox();
            label6 = new Label();
            txtValorUnitario = new TextBox();
            label5 = new Label();
            txtQuantidade = new TextBox();
            label8 = new Label();
            txtQtdItens = new TextBox();
            label9 = new Label();
            txtValorTotal = new TextBox();
            btnFinalizarPedido = new Button();
            btnCancelarPedido = new Button();
            btnExcluirPedido = new Button();
            label10 = new Label();
            textBox1 = new TextBox();
            cbxVendedorPedido = new ComboBox();
            clmProduto = new DataGridViewTextBoxColumn();
            clmQuantidade = new DataGridViewTextBoxColumn();
            clmValorUnitario = new DataGridViewTextBoxColumn();
            clmValorTotalIten = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensSelecionados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // imgListPedido
            // 
            imgListPedido.ColorDepth = ColorDepth.Depth32Bit;
            imgListPedido.ImageStream = (ImageListStreamer)resources.GetObject("imgListPedido.ImageStream");
            imgListPedido.TransparentColor = Color.Transparent;
            imgListPedido.Images.SetKeyName(0, "sisV.png");
            imgListPedido.Images.SetKeyName(1, "sisVico.ico");
            imgListPedido.Images.SetKeyName(2, "registro.png");
            imgListPedido.Images.SetKeyName(3, "bin.png");
            imgListPedido.Images.SetKeyName(4, "pen.png");
            imgListPedido.Images.SetKeyName(5, "plus.png");
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, pessoasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(183, 22);
            categoriasToolStripMenuItem.Text = "Categorias/Produtos";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // pessoasToolStripMenuItem
            // 
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(183, 22);
            pessoasToolStripMenuItem.Text = "Pessoas";
            pessoasToolStripMenuItem.Click += pessoasToolStripMenuItem_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(184, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 33);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Pedido";
            // 
            // btnAdicionarItenPedido
            // 
            btnAdicionarItenPedido.ImageIndex = 5;
            btnAdicionarItenPedido.ImageList = imgListPedido;
            btnAdicionarItenPedido.Location = new Point(196, 37);
            btnAdicionarItenPedido.Name = "btnAdicionarItenPedido";
            btnAdicionarItenPedido.Size = new Size(25, 25);
            btnAdicionarItenPedido.TabIndex = 4;
            btnAdicionarItenPedido.UseVisualStyleBackColor = true;
            btnAdicionarItenPedido.Click += btnAdicionarItenPedido_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 4;
            label2.Text = "Adicionar Produto";
            // 
            // cbxClientePedido
            // 
            cbxClientePedido.FormattingEnabled = true;
            cbxClientePedido.Location = new Point(62, 81);
            cbxClientePedido.Name = "cbxClientePedido";
            cbxClientePedido.Size = new Size(155, 23);
            cbxClientePedido.TabIndex = 2;
            cbxClientePedido.SelectedIndexChanged += cbxClientePedido_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Vendedor:";
            // 
            // dgvItensSelecionados
            // 
            dgvItensSelecionados.AllowUserToAddRows = false;
            dgvItensSelecionados.AllowUserToDeleteRows = false;
            dgvItensSelecionados.AllowUserToResizeColumns = false;
            dgvItensSelecionados.AllowUserToResizeRows = false;
            dgvItensSelecionados.BorderStyle = BorderStyle.None;
            dgvItensSelecionados.Columns.AddRange(new DataGridViewColumn[] { clmProduto, clmQuantidade, clmValorUnitario, clmValorTotalIten });
            dgvItensSelecionados.Location = new Point(6, 68);
            dgvItensSelecionados.Name = "dgvItensSelecionados";
            dgvItensSelecionados.ReadOnly = true;
            dgvItensSelecionados.Size = new Size(496, 146);
            dgvItensSelecionados.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluirItemPedido);
            groupBox1.Controls.Add(btnAterarItenPedido);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEstoque);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtValorUnitario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(dgvItensSelecionados);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(btnAdicionarItenPedido);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 286);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens do Pedido";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnExcluirItemPedido
            // 
            btnExcluirItemPedido.ImageIndex = 3;
            btnExcluirItemPedido.ImageList = imgListPedido;
            btnExcluirItemPedido.Location = new Point(478, 220);
            btnExcluirItemPedido.Name = "btnExcluirItemPedido";
            btnExcluirItemPedido.Size = new Size(25, 25);
            btnExcluirItemPedido.TabIndex = 10;
            btnExcluirItemPedido.UseVisualStyleBackColor = true;
            // 
            // btnAterarItenPedido
            // 
            btnAterarItenPedido.ImageIndex = 4;
            btnAterarItenPedido.ImageList = imgListPedido;
            btnAterarItenPedido.Location = new Point(447, 220);
            btnAterarItenPedido.Name = "btnAterarItenPedido";
            btnAterarItenPedido.Size = new Size(25, 25);
            btnAterarItenPedido.TabIndex = 9;
            btnAterarItenPedido.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 19);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 16;
            label7.Text = "Estoque";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(403, 37);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.ReadOnly = true;
            txtEstoque.Size = new Size(69, 23);
            txtEstoque.TabIndex = 7;
            txtEstoque.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 19);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 14;
            label6.Text = "Valor Unitário ";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(310, 37);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.ReadOnly = true;
            txtValorUnitario.Size = new Size(78, 23);
            txtValorUnitario.TabIndex = 6;
            txtValorUnitario.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 19);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(227, 37);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(69, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 348);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 18;
            label8.Text = "Itens";
            // 
            // txtQtdItens
            // 
            txtQtdItens.Location = new Point(25, 366);
            txtQtdItens.Name = "txtQtdItens";
            txtQtdItens.ReadOnly = true;
            txtQtdItens.Size = new Size(69, 23);
            txtQtdItens.TabIndex = 11;
            txtQtdItens.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 348);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 20;
            label9.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(109, 366);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(69, 23);
            txtValorTotal.TabIndex = 12;
            txtValorTotal.TabStop = false;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Location = new Point(538, 407);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(75, 23);
            btnFinalizarPedido.TabIndex = 13;
            btnFinalizarPedido.Text = "Finalizar";
            btnFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Location = new Point(619, 407);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(75, 23);
            btnCancelarPedido.TabIndex = 14;
            btnCancelarPedido.Text = "Cancelar";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPedido
            // 
            btnExcluirPedido.Location = new Point(700, 407);
            btnExcluirPedido.Name = "btnExcluirPedido";
            btnExcluirPedido.Size = new Size(75, 23);
            btnExcluirPedido.TabIndex = 16;
            btnExcluirPedido.Text = "Excluir";
            btnExcluirPedido.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 415);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 25;
            label10.Text = "Nro Pedido:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 407);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(69, 23);
            textBox1.TabIndex = 17;
            textBox1.TabStop = false;
            // 
            // cbxVendedorPedido
            // 
            cbxVendedorPedido.FormattingEnabled = true;
            cbxVendedorPedido.Location = new Point(78, 51);
            cbxVendedorPedido.Name = "cbxVendedorPedido";
            cbxVendedorPedido.Size = new Size(139, 23);
            cbxVendedorPedido.TabIndex = 26;
            cbxVendedorPedido.SelectedIndexChanged += cbxVendedorPedido_SelectedIndexChanged;
            // 
            // clmProduto
            // 
            clmProduto.DataPropertyName = "txtNome";
            clmProduto.HeaderText = "Produto";
            clmProduto.Name = "clmProduto";
            clmProduto.ReadOnly = true;
            clmProduto.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmProduto.Width = 150;
            // 
            // clmQuantidade
            // 
            clmQuantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "D4";
            clmQuantidade.DefaultCellStyle = dataGridViewCellStyle7;
            clmQuantidade.HeaderText = "Quantidade";
            clmQuantidade.Name = "clmQuantidade";
            clmQuantidade.ReadOnly = true;
            // 
            // clmValorUnitario
            // 
            clmValorUnitario.DataPropertyName = "Preco";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C2";
            clmValorUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            clmValorUnitario.HeaderText = "Valor Unitário";
            clmValorUnitario.Name = "clmValorUnitario";
            clmValorUnitario.ReadOnly = true;
            // 
            // clmValorTotalIten
            // 
            clmValorTotalIten.DataPropertyName = "ValorTotalIten";
            dataGridViewCellStyle9.Format = "C2";
            clmValorTotalIten.DefaultCellStyle = dataGridViewCellStyle9;
            clmValorTotalIten.HeaderText = "Valor Total Iten";
            clmValorTotalIten.Name = "clmValorTotalIten";
            clmValorTotalIten.ReadOnly = true;
            clmValorTotalIten.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxVendedorPedido);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(btnExcluirPedido);
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(label9);
            Controls.Add(txtValorTotal);
            Controls.Add(label8);
            Controls.Add(txtQtdItens);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxClientePedido);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pdv Sistema de Vendas";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensSelecionados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imgListPedido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private TextBox txtNome;
        private Label label1;
        private Button btnAdicionarItenPedido;
        private Label label2;
        private ComboBox cbxClientePedido;
        private Label label3;
        private Label label4;
        private DataGridView dgvItensSelecionados;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtQuantidade;
        private Label label7;
        private TextBox txtEstoque;
        private Label label6;
        private TextBox txtValorUnitario;
        private Button btnExcluirItemPedido;
        private Button btnAterarItenPedido;
        private Label label8;
        private TextBox txtQtdItens;
        private Label label9;
        private TextBox txtValorTotal;
        private Button btnFinalizarPedido;
        private Button btnCancelarPedido;
        private Button btnExcluirPedido;
        private Label label10;
        private TextBox textBox1;
        private ComboBox cbxVendedorPedido;
        private DataGridViewTextBoxColumn clmProduto;
        private DataGridViewTextBoxColumn clmQuantidade;
        private DataGridViewTextBoxColumn clmValorUnitario;
        private DataGridViewTextBoxColumn clmValorTotalIten;
    }
}
