using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("ReservaLivros")]
    public class ReservaLivro
    {
        [Key]
        public int IdReservaLivro { get; set; }
        public DateTime DataReservaLivro { get; set; }
        public DateTime DataDevolucaoLivro { get; set; }
        public Cliente Cliente { get; set; }
        public DadosLivro DadosLivro { get; set; }
        public int ClienteId { get; set; }
        public int LivroId { get; set; }
    }
}
