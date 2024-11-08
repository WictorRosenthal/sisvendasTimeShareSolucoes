using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required, MaxLength(150)]
        public string Nome { get; set; }

        public int Estoque { get; set; }

        public Double Preco { get; set; }

        public string? Descricao { get; set; }

        public int? QtdMinima { get; set; }


        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
