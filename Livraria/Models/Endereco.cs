using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        [Display(Name = "Rua:")]
        public string endereco { get; set; }

        [Display(Name = "CEP:")]
        public string Cep { get; set; }
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }
        [Display(Name = "Estado:")]
        public string Uf { get; set; }
    }
}
