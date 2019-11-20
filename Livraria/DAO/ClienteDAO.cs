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

        public Cliente BuscarPorID(int id)
        {
            return _context.Clientes.Find(id);
        }

        public Cliente BuscaPorCpf(Cliente cliente)
        {
            return _context.Clientes.Where(x => x.Cpf.Equals(cliente.Cpf)).FirstOrDefault();
        }
        public bool CadastrarCliente(Cliente cliente)
        {
            if (BuscaPorCpf(cliente) != null)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            
            return false;
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
    }


}
