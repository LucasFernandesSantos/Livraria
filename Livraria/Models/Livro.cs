using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("Livros")]
    public class Livro
    {
       
        public int MyProperty { get; set; }
    }
}
