using Microsoft.EntityFrameworkCore;
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
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void FormCadPessoa_Load(object sender, EventArgs e)
        {
            using (var db = new SisVendasContext())
            {
                AtualizarClientes(db);
            }

        }
        #region Método para Atualizar Clientes
        private void AtualizarClientes(SisVendasContext db)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvCliente.DataSource = db.Pessoas.ToList();
            this.Cursor = Cursors.Default;
        }


        #endregion
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            using (var form = new FormPessoa())
            {
                form.Text = "Adicionar Cliente";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new SisVendasContext())
                    {
                        Pessoa pessoa = new Pessoa();
                        pessoa.Nome = form.txtNome.Text;
                        pessoa.CpfCnpj = form.mtbCpfCnpj.Text;
                        pessoa.Apelido = form.txtApelido.Text;
                        db.Pessoas.Add(pessoa);
                        db.SaveChanges();
                        AtualizarClientes(db);
                        MessageBox.Show("Cliente cadastrado com sucesso", "Informação");

                    }
                }
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaselecionada = null;
            if (dgvCliente.SelectedRows.Count >0) 
            { 
                linhaselecionada = dgvCliente.SelectedRows[0];
                Pessoa pessoa = linhaselecionada.DataBoundItem as Pessoa;
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir esse cliente?", "Aviso!", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new SisVendasContext())
                    {
                        db.Pessoas.Attach(pessoa);
                        db.Entry(pessoa).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarClientes(db);
                        MessageBox.Show("Cliente Excluido", "Informação");
                    }
                }
            }     
        }
    }
}
