using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    class UnidadeDeMedida
    {
        [Key]
        public int IdUnidadeDeMedida { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
