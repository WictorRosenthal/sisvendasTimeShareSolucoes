using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    class ContatoPessoa
    {
        [Key]
        public int IdContatoPessoa { get; set; }

        [MaxLength(3)]
        public string DDDfone { get; set; }

        [MaxLength(10)]
        public string Telefone { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
