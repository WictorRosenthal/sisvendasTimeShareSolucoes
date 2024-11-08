using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    public class ItenVenda
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Venda")]
        public int IdVenda{ get; set; }
        public Venda Venda { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Double Subtotal { get; set; }

    }
}
