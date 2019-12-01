using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.DAO
{
    public class CategoriaDAO
    {
        private readonly Context _context;
        public CategoriaDAO(Context context)
        {
            _context = context;
        }
        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public bool Cadastrar(Categoria objeto)
        {
            if (BuscarPorNome(objeto) == null)
            {
                _context.Categorias.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public Categoria BuscarPorNome(Categoria categoria)
        {
            return _context.Categorias.FirstOrDefault
                (x => x.Nome.Equals(categoria.Nome));
        }

        public List<Categoria> ListarTodos()
        {
            return _context.Categorias.ToList();
        }
    }
}
