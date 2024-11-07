using SisVendas.Models;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
            using (var form = new FormItens())
            { 
                form.ShowDialog();
            }
        }
    }
}
