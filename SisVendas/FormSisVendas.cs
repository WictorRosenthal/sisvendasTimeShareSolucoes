using SisVendas.Models;
using System;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormCadCategoriaProduto())
            {
                form.ShowDialog();
            }
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormPessoa())
            {
                form.ShowDialog();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpbPedidosAdicionados_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxVendedorPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new SisVendasContext())
            {
                cbxVendedorPedido.DataSource = db.Pessoas.ToList();
            }
        }

        private void cbxClientePedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new SisVendasContext())
            {
                cbxClientePedido.DataSource = db.Pessoas.ToList();
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

        private void label2_Click(object sender, EventArgs e)
        {

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

        }
    }
}
