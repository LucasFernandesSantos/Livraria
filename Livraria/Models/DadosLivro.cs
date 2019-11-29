using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("DadosLivros")]
    public class DadosLivro
    {
        [Key]
        public int DadosLivroId { get; set; }
        //genero
        public int Quantidade { get; set; }
        public string Volume { get; set; }
        public string Autor { get; set; }
        [NotMapped]
        public string[] Authors { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        //public string[] Authors { get; set; }
        //  public string Authors { get; set; }

    }
}
