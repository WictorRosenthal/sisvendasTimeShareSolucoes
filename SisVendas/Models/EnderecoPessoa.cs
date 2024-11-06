using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    class EnderecoPessoa
    {
        [Key]
        public int IdEnderecoPessoa { get; set; }

        [MaxLength(8)]
        public string cep { get; set; }

        [MaxLength(250)]
        public string Endereco { get; set; }

        [MaxLength(100)]
        public string Numero { get; set; }

        [MaxLength(250)]
        public string Bairro { get; set; }

        [MaxLength(250)]
        public string Complemento { get; set; }

        [MaxLength(2)]
        public string UF { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }




    }
}
