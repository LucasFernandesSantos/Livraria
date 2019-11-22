using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.DAO
{
    public class ClienteDAO
    {
        private readonly Context _context;
        public ClienteDAO(Context context)
        {
            _context = context;
        }

        public bool AutenticarLogin(string cpf, string senha)
        {
            var result = _context.Clientes.FirstOrDefault(x => x.Cpf.Equals(cpf) && x.Senha.Equals(senha));
            if (result != null)
            {
                return true;
            }
            return false;
        }


        public Cliente BuscarPorID(int id)
        {
            return _context.Clientes.Find(id);
        }

        public Cliente BuscaPorCpf(Cliente cliente)
        {
            return _context.Clientes.Where(x => x.Cpf.Equals(cliente.Cpf)).FirstOrDefault();
        }
        public Cliente CadastrarCliente(Cliente cliente)
        {
            if (BuscaPorCpf(cliente) != null)
            {
                cliente = null;
                return cliente;
            }
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
    }


}
