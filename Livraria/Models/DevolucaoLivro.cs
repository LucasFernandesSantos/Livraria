using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("DevolucaoLivros")]
    public class DevolucaoLivro
    {
        [Key]
        public int IdDevolucaoLivro { get; set; }  
        public Cliente Cliente { get; set; }
        public DadosLivro DadosLivro { get; set; }
        public virtual ReservaLivro ReservaLivro { get; set; }
    }
}
