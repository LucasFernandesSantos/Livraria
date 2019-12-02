using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("Generos")]
    public class GeneroLivro
    {
        [Key]
        public int GeneroLivroId { get; set; }
        public string Nome { get; set; }
    }
}

