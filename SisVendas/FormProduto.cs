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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            using (var db = new SisVendasContext())
            {
                AtualizarCbxCategoria(db);
            }
        }
        private void AtualizarCbxCategoria(SisVendasContext db)
        {
            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.ValueMember = "IdCategoria";
        }
        private void FormProduto_Load(object sender, EventArgs e)
        {
             

        }


    }
}
