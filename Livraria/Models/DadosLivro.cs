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
        public string Autor { get; set; }
        [NotMapped]
        public string[] Authors { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Categoria Categoria { get; set; }
        public string Imagem { get; set; }
        public string Genero { get; set; }
        public string Descricao { get; set; }
    }
}
