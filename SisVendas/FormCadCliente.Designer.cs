namespace SisVendas
{
    partial class FormCadCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCliente));
            dgvCliente = new DataGridView();
            clmIdPessoa = new DataGridViewTextBoxColumn();
            clmCliente = new DataGridViewTextBoxColumn();
            clmCpfCnpj = new DataGridViewTextBoxColumn();
            clmApelido = new DataGridViewTextBoxColumn();
            btnExcluirProduto = new Button();
            imgListCadastroPessoa = new ImageList(components);
            btnAdicionarCliente = new Button();
            label2 = new Label();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AllowUserToResizeColumns = false;
            dgvCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { clmIdPessoa, clmCliente, clmCpfCnpj, clmApelido });
            dgvCliente.Location = new Point(12, 89);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(507, 293);
            dgvCliente.TabIndex = 12;
            // 
            // clmIdPessoa
            // 
            clmIdPessoa.DataPropertyName = "IdPessoa";
            dataGridViewCellStyle2.Format = "D4";
            clmIdPessoa.DefaultCellStyle = dataGridViewCellStyle2;
            clmIdPessoa.HeaderText = "IdPessoa";
            clmIdPessoa.Name = "clmIdPessoa";
            clmIdPessoa.ReadOnly = true;
            clmIdPessoa.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmIdPessoa.Width = 50;
            // 
            // clmCliente
            // 
            clmCliente.DataPropertyName = "Nome";
            clmCliente.HeaderText = "Cliente";
            clmCliente.Name = "clmCliente";
            clmCliente.ReadOnly = true;
            clmCliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmCliente.Width = 200;
            // 
            // clmCpfCnpj
            // 
            clmCpfCnpj.DataPropertyName = "CpfCnpj";
            clmCpfCnpj.HeaderText = "Cpf/Cnpj";
            clmCpfCnpj.Name = "clmCpfCnpj";
            clmCpfCnpj.ReadOnly = true;
            clmCpfCnpj.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // clmApelido
            // 
            clmApelido.DataPropertyName = "Apelido";
            clmApelido.HeaderText = "Apelido";
            clmApelido.Name = "clmApelido";
            clmApelido.ReadOnly = true;
            clmApelido.SortMode = DataGridViewColumnSortMode.NotSortable;
            clmApelido.Width = 150;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.ImageIndex = 0;
            btnExcluirProduto.ImageList = imgListCadastroPessoa;
            btnExcluirProduto.Location = new Point(150, 31);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(25, 25);
            btnExcluirProduto.TabIndex = 11;
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // imgListCadastroPessoa
            // 
            imgListCadastroPessoa.ColorDepth = ColorDepth.Depth32Bit;
            imgListCadastroPessoa.ImageStream = (ImageListStreamer)resources.GetObject("imgListCadastroPessoa.ImageStream");
            imgListCadastroPessoa.TransparentColor = Color.Transparent;
            imgListCadastroPessoa.Images.SetKeyName(0, "bin.png");
            imgListCadastroPessoa.Images.SetKeyName(1, "edit.png");
            imgListCadastroPessoa.Images.SetKeyName(2, "pen.png");
            imgListCadastroPessoa.Images.SetKeyName(3, "plus.png");
            imgListCadastroPessoa.Images.SetKeyName(4, "procurar.png");
            imgListCadastroPessoa.Images.SetKeyName(5, "sisV.png");
            imgListCadastroPessoa.Images.SetKeyName(6, "sisVico.ico");
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.ImageIndex = 3;
            btnAdicionarCliente.ImageList = imgListCadastroPessoa;
            btnAdicionarCliente.Location = new Point(119, 31);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(25, 25);
            btnAdicionarCliente.TabIndex = 9;
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 8;
            label2.Text = "Adicionar Cliente:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FormCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(dgvCliente);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadCliente";
            Text = "Cadastro de Cliente";
            Load += FormCadPessoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCliente;
        private Button btnExcluirProduto;
        private Button btnAdicionarCliente;
        private Label label2;
        private ImageList imageList1;
        private ImageList imgListCadastroPessoa;
        private DataGridViewTextBoxColumn clmIdPessoa;
        private DataGridViewTextBoxColumn clmCliente;
        private DataGridViewTextBoxColumn clmCpfCnpj;
        private DataGridViewTextBoxColumn clmApelido;
    }
}