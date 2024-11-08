using SisVendas.Models;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Form1 : Form
    {
        #region Váriaveis de Quantidade, SubTotal, Total, Preço e Carrinho.
        int qtd;
        double subtotal, total, preco;
        DataTable carrinho = new DataTable();

        #endregion
        public Form1()
        {
            InitializeComponent();

            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(double));
            carrinho.Columns.Add("Subtotal", typeof(double));

            dgvItensSelecionados.DataSource = carrinho;
        }
        #region Método que busca a pessoa
        public Pessoa RetornaPessoa(string nome)
        {
            try
            {
                using (var db = new SisVendasContext())
                {
                    Pessoa pessoa = db.Pessoas.FirstOrDefault(p => p.Nome == nome);


                    if (pessoa != null)
                    {
                        return pessoa;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum pessoa com esse nome foi encontrado!", "Informação");
                        return null;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro.Message, "Informação");
                return null;
            }
        }
        #endregion
        #region Meétodo que vai buscar o produto por nome
        public Produto RetornaProduto(string nome)
        {
            try
            {
                using (var db = new SisVendasContext())
                {
                    Produto produto = db.Produtos.FirstOrDefault(p => p.Nome == nome);


                    if (produto != null)
                    {
                        return produto;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado com este nome!", "Informação");
                        return null;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro.Message, "Informação");
                return null;
            }
        }

        #endregion
        #region Método Imprimir
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Arial", 12, FontStyle.Bold);
            Font font = new Font("Arial", 10, FontStyle.Regular);
            float lineHeight = font.GetHeight(e.Graphics);
            float startX = 10;
            float startY = 20;
            float offsetY = 0;

            e.Graphics.DrawString("Cupom Fiscal", fontTitle, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight * 2;

            e.Graphics.DrawString("Produto", font, Brushes.Black, startX, startY + offsetY);
            e.Graphics.DrawString("Qtd", font, Brushes.Black, startX + 150, startY + offsetY);
            e.Graphics.DrawString("Preço", font, Brushes.Black, startX + 200, startY + offsetY);
            e.Graphics.DrawString("Subtotal", font, Brushes.Black, startX + 280, startY + offsetY);

            offsetY += lineHeight;

            e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + 360, startY + offsetY);
            offsetY += lineHeight;

            double total = 0;
            foreach (DataGridViewRow row in dgvItensSelecionados.Rows)
            {
                if (row.IsNewRow) continue;

                string produto = row.Cells["Produto"].Value?.ToString() ?? string.Empty;
                string quantidade = row.Cells["Qtd"].Value?.ToString() ?? "0";
                string preco = row.Cells["Preço"].Value?.ToString() ?? "0";
                string subtotal = row.Cells["Subtotal"].Value?.ToString() ?? "0";

                e.Graphics.DrawString(produto, font, Brushes.Black, startX, startY + offsetY);
                e.Graphics.DrawString(quantidade, font, Brushes.Black, startX + 150, startY + offsetY);
                e.Graphics.DrawString(preco, font, Brushes.Black, startX + 200, startY + offsetY);
                e.Graphics.DrawString(subtotal, font, Brushes.Black, startX + 280, startY + offsetY);

                offsetY += lineHeight;

                total += Convert.ToDouble(subtotal);
            }

            offsetY += lineHeight;
            e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + 360, startY + offsetY);
            offsetY += lineHeight;

            e.Graphics.DrawString("Total", fontTitle, Brushes.Black, startX, startY + offsetY);
            e.Graphics.DrawString(total.ToString("C"), fontTitle, Brushes.Black, startX + 280, startY + offsetY);
        }

        #endregion
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormCadCategoriaProduto())
            {
                form.ShowDialog();
            }
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormCadCliente())
            {
                form.ShowDialog();
            }
        }

        private void btnAdicionarItenPedido_Click(object sender, EventArgs e)
        {

            qtd = int.Parse(txtQuantidade.Text);
            preco = double.Parse(txtValorUnitario.Text, NumberStyles.Currency, new CultureInfo("pt-BR"));
            //preco = double.Parse(txtValorUnitario.Text);
            subtotal = qtd * preco;
            total += subtotal;
            carrinho.Rows.Add(txtNome.Text, txtQuantidade.Text, preco, subtotal);
            txtValorTotal.Text = total.ToString();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValorUnitario.Clear();
            txtEstoque.Clear();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nomeProduto = txtNome.Text.Trim();
                Produto produto = RetornaProduto(nomeProduto);

                if (produto != null)
                {
                    txtValorUnitario.Text = produto.Preco.ToString("C");
                    txtEstoque.Text = produto.Estoque.ToString();
                }
                else
                {
                    txtValorUnitario.Text = "";
                    txtEstoque.Text = "";

                }

            }
        }
        private void btnExcluirItemPedido_Click(object sender, EventArgs e)
        {
            double subproduto = double.Parse(dgvItensSelecionados.CurrentRow.Cells[3].Value.ToString());
            int indice = dgvItensSelecionados.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];
            carrinho.Rows.RemoveAt(indice);
            carrinho.AcceptChanges();

            total -= subproduto;
            txtValorTotal.Text = subproduto.ToString("C");

            MessageBox.Show("Item Removido do carrinho", "Informação");
            txtValorTotal.Clear();
        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            printPedido = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printPedido.PrinterSettings = ps;
            printPedido.PrintPage += Imprimir;
            printPedido.Print();
        }
        
        private void cbxClientePedido_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (e.KeyChar == (char)Keys.Enter)
            {
                string nomeCliente = cbxClientePedido.Text.Trim();
                Pessoa pessoa = RetornaPessoa(nomeCliente);

                if (pessoa != null)
                {
                    cbxClientePedido.Text = pessoa.Nome;
                    txtIdPessoa.Text = pessoa.IdPessoa.ToString();
                }
                else
                {

                    cbxClientePedido.Text = "";
                }

            }
        }

    }
}
