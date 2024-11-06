using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    class SisVendasContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<EnderecoPessoa> EnderecoPessoas { get; set; }

        public DbSet<ContatoPessoa> contatoPessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseNpgsql("Data Source=sisvendas.db");
            options.UseNpgsql("Host=localhost;Port=5432;Database=sisvendas.db;Username=postgres;Password=1234");
            
        }


    }
}
