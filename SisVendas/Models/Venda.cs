using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    public class Venda
    {
        [Key]
        public int IdVenda { get; set; }   

        public DateTime DataVenda { get; set; }

        public Double TotalVenda { get; set; }

        public string Descricao { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
