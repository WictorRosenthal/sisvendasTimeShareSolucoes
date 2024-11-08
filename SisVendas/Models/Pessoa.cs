using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required, MaxLength(150)]
        public string Nome { get; set; }

        [MaxLength(150)]
        public string Apelido { get; set; }

        [MaxLength(150)]
        public string CpfCnpj { get; set; }



    }
}
