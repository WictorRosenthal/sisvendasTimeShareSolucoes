using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required, MaxLength(150)]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
