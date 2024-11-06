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
            label1 = new Label();
            label2 = new Label();
            cbxCategoria = new ComboBox();
            btnAdicionarCategoria = new Button();
            imgListAddEdEx = new ImageList(components);
            btnEditarCategoria = new Button();
            btnExcluirCategoria = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 109);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Adicionar Produtos";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(12, 29);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 2;
            // 
            // btnAdicionarCategoria
            // 
            btnAdicionarCategoria.ImageIndex = 2;
            btnAdicionarCategoria.ImageList = imgListAddEdEx;
            btnAdicionarCategoria.Location = new Point(139, 29);
            btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            btnAdicionarCategoria.Size = new Size(25, 25);
            btnAdicionarCategoria.TabIndex = 3;
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
            btnEditarCategoria.TabIndex = 4;
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
            btnExcluirCategoria.TabIndex = 5;
            btnExcluirCategoria.UseVisualStyleBackColor = true;
            btnExcluirCategoria.Click += btnExcluirCategoria_Click;
            // 
            // button4
            // 
            button4.Location = new Point(475, 105);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(556, 105);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(637, 105);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(663, 150);
            dataGridView1.TabIndex = 9;
            // 
            // FormCadCategoriaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnExcluirCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAdicionarCategoria);
            Controls.Add(cbxCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadCategoriaProduto";
            Text = "FormCadCategoriaProduto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private ImageList imgListAddEdEx;
    }
}