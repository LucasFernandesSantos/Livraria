using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public Cliente()
        {
            Endereco = new Endereco();
            ReservaLivro = new List<ReservaLivro>();
            DevolucaoLivro = new List<DevolucaoLivro>();
        }
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public List<ReservaLivro> ReservaLivro { get; set; }
        public List<DevolucaoLivro> DevolucaoLivro { get; set; }
        public string StatusCliente { get; set; }
    }
}
