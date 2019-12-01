using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Livraria.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }

        
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
