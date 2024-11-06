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
    public partial class FormCadCategoriaProduto : Form
    {
        public FormCadCategoriaProduto()
        {
            InitializeComponent();
            using (var db = new SisVendasContext())
            {
                AtualizarCbxCategoria(db);
            }
        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategoria())
            {
                form.Text = "Nova Categoria";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new SisVendasContext())
                    {
                        Categoria categoria = new Categoria();
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Add(categoria);
                        db.SaveChanges();
                        AtualizarCbxCategoria(db);
                        MessageBox.Show("Categoria adicionada com sucesso.", "Informação");
                    }
                }
            }
        }

        private void AtualizarCbxCategoria(SisVendasContext db)
        {
            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.ValueMember = "IdCategoria";
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {

            using (var form = new FormCategoria())
            {
                form.Text = "Editar Categoria";
                form.txtNome.Text = cbxCategoria.Text;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new SisVendasContext())
                    {
                        Categoria categoria = (cbxCategoria.SelectedItem as Categoria);
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Modified;
                        db.SaveChanges();
                        AtualizarCbxCategoria(db);
                        cbxCategoria.SelectedItem = categoria;
                        MessageBox.Show("Categoria alterada com sucesso.", "Informação");

                    }
                }
            }
        }
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir a categoria?", "Aviso!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new SisVendasContext())
                {
                    Categoria categoria = cbxCategoria.SelectedItem as Categoria;

                    if (categoria == null)
                    {
                        MessageBox.Show("Selecione uma categoria válida.", "Erro");
                        return;
                    }
                    int qtdeProdutos = db.Produtos.Count(x => x.IdCategoria == categoria.IdCategoria);

                    if (qtdeProdutos == 0)
                    {
                        db.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarCbxCategoria(db);

                        MessageBox.Show("Categoria excluída com sucesso", "Informação");
                    }
                    else
                    {
                        MessageBox.Show("Não é possível excluir a categoria, pois há produtos vinculados.", "Aviso!");
                    }
                }
            }
        }

    }

}
