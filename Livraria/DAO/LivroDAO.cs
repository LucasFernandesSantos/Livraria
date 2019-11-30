using Livraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.DAO
{
    public class LivroDAO
    {
        private readonly Context _context;
        public LivroDAO(Context context)
        {
            _context = context;
        }

        public List<DadosLivro> ListarLivro()
        {
            return _context.Dados.ToList();
        }

        public DadosLivro BuscarPorTitulo(DadosLivro dados)
        {
            return _context.Dados.Where(x => x.Title.Equals(dados.Title)).FirstOrDefault();
        }

        public void RemoverLivro(int id)
        {
            _context.Dados.Remove(BuscarPorID(id));
            _context.SaveChanges();
        }
        public DadosLivro BuscarPorID(int? id)
        {
            return _context.Dados.Find(id);
        }
        public DadosLivro CadastrarLivro(DadosLivro dados)
        {
            if (BuscarPorTitulo(dados) != null)
            {
                dados = null;
                return dados;
            }

            dados.Status = "Disponível";
            _context.Dados.Add(dados);
            _context.SaveChanges();
            return dados;
        }
        public void EditarLivro(DadosLivro dados)
        {
            _context.Dados.Update(dados);
            _context.SaveChanges();
        }

        public List<DadosLivro> ListarPorGenero(int? id)
        {
            return _context.Dados.Include(x => x.Genero).Where(x => x.Genero.GeneroId == id).ToList();
        }

        //public Livro BuscarPorID(int? id)
        //{
        //    return _context.Livros.Find(id);
        //}

        //public Livro BuscarPorNome(Livro livro)
        //{
        //    return _context.Livros.Where(x => x.items.volumeInfo.Title.Equals(livro.items.volumeInfo.Title)).FirstOrDefault();
        //}
        //public Livro CadastrarLivro(Livro livro)
        //{
        //    if (BuscarPorNome(livro) != null)
        //    {
        //      livro = null;
        //        return livro;
        //    }
        //    _context.Livros.Add(livro);
        //    _context.SaveChanges();
        //    return livro;
        //}

        //public List<Livro> ListarTodos()
        //{
        //    return _context.Livros.ToList();
        //}

        //public void EditarLivro(Livro livro)
        //{
        //    _context.Livros.Update(livro);
        //    _context.SaveChanges();
        //}

        //public void RemoverLivro(int id)
        //{
        //    _context.Livros.Remove(BuscarPorID(id));
        //    _context.SaveChanges();
        //}
    }
}
