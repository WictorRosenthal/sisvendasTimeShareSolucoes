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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnImprimirPedido = new Button();
            dgvItensSelecionados = new DataGridView();
            btnExcluirItemPedido = new Button();
            label7 = new Label();
            txtEstoque = new TextBox();
            label6 = new Label();
            txtValorTotal = new TextBox();
            txtValorUnitario = new TextBox();
            label5 = new Label();
            txtQuantidade = new TextBox();
            printPedido = new System.Drawing.Printing.PrintDocument();
            txtIdPessoa = new TextBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            gpbPendente = new GroupBox();
            gpbProducao = new GroupBox();
            gpbRetirada = new GroupBox();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensSelecionados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            menuStrip1.Size = new Size(858, 24);
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
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F);
            label1.Location = new Point(208, 33);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 2;
            label1.Text = "Pedido";
            // 
            // btnAdicionarItenPedido
            // 
            btnAdicionarItenPedido.ImageIndex = 5;
            btnAdicionarItenPedido.ImageList = imgListPedido;
            btnAdicionarItenPedido.Location = new Point(430, 36);
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
            label2.Size = new Size(148, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite o nome do produto!";
            // 
            // cbxClientePedido
            // 
            cbxClientePedido.FormattingEnabled = true;
            cbxClientePedido.Location = new Point(12, 85);
            cbxClientePedido.Name = "cbxClientePedido";
            cbxClientePedido.Size = new Size(204, 23);
            cbxClientePedido.TabIndex = 2;
            cbxClientePedido.KeyPress += cbxClientePedido_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(204, 15);
            label3.TabIndex = 7;
            label3.Text = "Digite o nome do cliente para buscar!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnImprimirPedido);
            groupBox1.Controls.Add(dgvItensSelecionados);
            groupBox1.Controls.Add(btnExcluirItemPedido);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEstoque);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtValorTotal);
            groupBox1.Controls.Add(txtValorUnitario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(btnAdicionarItenPedido);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 286);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens do Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 229);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 19;
            label4.Text = "Valor Total:";
            // 
            // btnImprimirPedido
            // 
            btnImprimirPedido.Location = new Point(430, 225);
            btnImprimirPedido.Name = "btnImprimirPedido";
            btnImprimirPedido.Size = new Size(106, 23);
            btnImprimirPedido.TabIndex = 18;
            btnImprimirPedido.Text = "Imprimir Pedido";
            btnImprimirPedido.UseVisualStyleBackColor = true;
            btnImprimirPedido.Click += btnImprimirPedido_Click;
            // 
            // dgvItensSelecionados
            // 
            dgvItensSelecionados.AllowUserToAddRows = false;
            dgvItensSelecionados.AllowUserToDeleteRows = false;
            dgvItensSelecionados.AllowUserToResizeColumns = false;
            dgvItensSelecionados.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItensSelecionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItensSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensSelecionados.Location = new Point(6, 66);
            dgvItensSelecionados.Name = "dgvItensSelecionados";
            dgvItensSelecionados.ReadOnly = true;
            dgvItensSelecionados.RightToLeft = RightToLeft.No;
            dgvItensSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensSelecionados.Size = new Size(532, 150);
            dgvItensSelecionados.TabIndex = 17;
            // 
            // btnExcluirItemPedido
            // 
            btnExcluirItemPedido.ImageIndex = 3;
            btnExcluirItemPedido.ImageList = imgListPedido;
            btnExcluirItemPedido.Location = new Point(461, 35);
            btnExcluirItemPedido.Name = "btnExcluirItemPedido";
            btnExcluirItemPedido.Size = new Size(25, 25);
            btnExcluirItemPedido.TabIndex = 10;
            btnExcluirItemPedido.UseVisualStyleBackColor = true;
            btnExcluirItemPedido.Click += btnExcluirItemPedido_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 19);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 16;
            label7.Text = "Estoque";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(356, 37);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.ReadOnly = true;
            txtEstoque.Size = new Size(69, 23);
            txtEstoque.TabIndex = 7;
            txtEstoque.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 19);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 14;
            label6.Text = "Valor Unitário ";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(79, 225);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(69, 23);
            txtValorTotal.TabIndex = 12;
            txtValorTotal.TabStop = false;
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(271, 37);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.ReadOnly = true;
            txtValorUnitario.Size = new Size(78, 23);
            txtValorUnitario.TabIndex = 6;
            txtValorUnitario.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 19);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(196, 37);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(69, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // txtIdPessoa
            // 
            txtIdPessoa.Location = new Point(316, 85);
            txtIdPessoa.Name = "txtIdPessoa";
            txtIdPessoa.ReadOnly = true;
            txtIdPessoa.Size = new Size(100, 23);
            txtIdPessoa.TabIndex = 29;
            txtIdPessoa.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(223, 89);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 30;
            label12.Text = "Codigo cliente:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sisV;
            pictureBox1.Location = new Point(162, 420);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 144);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // gpbPendente
            // 
            gpbPendente.Location = new Point(573, 125);
            gpbPendente.Name = "gpbPendente";
            gpbPendente.Size = new Size(273, 100);
            gpbPendente.TabIndex = 32;
            gpbPendente.TabStop = false;
            gpbPendente.Text = "Pendentes";
            // 
            // gpbProducao
            // 
            gpbProducao.Location = new Point(573, 231);
            gpbProducao.Name = "gpbProducao";
            gpbProducao.Size = new Size(273, 100);
            gpbProducao.TabIndex = 33;
            gpbProducao.TabStop = false;
            gpbProducao.Text = "Produção";
            // 
            // gpbRetirada
            // 
            gpbRetirada.Location = new Point(573, 344);
            gpbRetirada.Name = "gpbRetirada";
            gpbRetirada.Size = new Size(273, 100);
            gpbRetirada.TabIndex = 34;
            gpbRetirada.TabStop = false;
            gpbRetirada.Text = "Retirada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 20F);
            label8.Location = new Point(657, 71);
            label8.Name = "label8";
            label8.Size = new Size(114, 38);
            label8.TabIndex = 35;
            label8.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(858, 576);
            Controls.Add(label8);
            Controls.Add(gpbRetirada);
            Controls.Add(gpbProducao);
            Controls.Add(gpbPendente);
            Controls.Add(pictureBox1);
            Controls.Add(label12);
            Controls.Add(txtIdPessoa);
            Controls.Add(label3);
            Controls.Add(cbxClientePedido);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Pdv Sistema de Vendas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensSelecionados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private TextBox txtEstoque;
        private Label label6;
        private TextBox txtValorUnitario;
        private Button btnExcluirItemPedido;
        private TextBox txtValorTotal;
        private DataGridView dgvItensSelecionados;
        public TextBox txtQuantidade;
        private Button btnImprimirPedido;
        private System.Drawing.Printing.PrintDocument printPedido;
        private TextBox txtIdPessoa;
        private Label label12;
        private Label label4;
        private PictureBox pictureBox1;
        private GroupBox gpbPendente;
        private GroupBox gpbProducao;
        private GroupBox gpbRetirada;
        private Label label8;
    }
}
