using Livraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.DAO
{
    public class GeneroDAO
    {
        private readonly Context _context;
        public GeneroDAO(Context context)
        {
            _context = context;
        }
        public Genero BuscarGeneroPorId(int id)
        {
            return _context.Generos.Find(id);
        }

        public bool CadastrarGenero(Genero objeto)
        {
            if (BuscarPorNome(objeto) == null)
            {
                _context.Generos.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        //public Genero CadastrarGenero(Genero genero)
        //{
        //    if (BuscarPorNome(genero) != null)
        //    {
        //        genero = null;
        //        return genero;
        //    }
        //    _context.Generos.Add(genero);
        //    _context.SaveChanges();
        //    return genero;
        //}
        public Genero BuscarPorNome(Genero genero)
        {
            return _context.Generos.FirstOrDefault
                (x => x.Nome.Equals(genero.Nome));
        }

        public List<Genero> ListarTodosGeneros()
        {
            return _context.Generos.ToList();
        }

        public void EditarGenero(Genero genero)
        {
            _context.Generos.Update(genero);
            _context.SaveChanges();
        }

        public void RemoverGenero(int id)
        {
            _context.Generos.Remove(BuscarGeneroPorId(id));
            _context.SaveChanges();
        }
    }
}
