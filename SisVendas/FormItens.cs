using SisVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class FormItens : Form
    {
        public FormItens()
        {
            InitializeComponent();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            using (var db = new SisVendasContext())
            {
                var produtos = db.Produtos.ToList();
                cbxItensProduto.DataSource = produtos;
                cbxItensProduto.DisplayMember = "Nome";
                cbxItensProduto.ValueMember = "IdProduto";
            }
        }
    }
}
