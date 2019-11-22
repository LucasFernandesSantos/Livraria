using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public class Adm
    {
        public Adm()
        {
            Login = "ADM";
            Senha = "ADM";
        }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
