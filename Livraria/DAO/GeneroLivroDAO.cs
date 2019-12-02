using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.DAO
{
    public class GeneroLivroDAO
    {
        private readonly Context _context;
        public GeneroLivroDAO(Context context)
        {
            _context = context;
        }

        public GeneroLivro BuscarPorId(int id)
        {
            return _context.Generos.Find(id);
        }

        public bool CadastrarGenero(GeneroLivro objeto)
        {
            if (BuscarPorNome(objeto) == null) 
            {
                _context.Generos.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public GeneroLivro BuscarPorNome(GeneroLivro generoLivro)
        {
            return _context.Generos.FirstOrDefault(x => x.Nome.Equals(generoLivro.Nome));
        }

        public List<GeneroLivro> ListarTodos()
        {
            return _context.Generos.ToList();
        }
    }
}
