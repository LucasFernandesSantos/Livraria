using Livraria.Models;
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

        public DadosLivro BuscarPorNome(DadosLivro dados)
        {
            return _context.Dados.Where(x => x.Authors.Equals(dados.Authors)).FirstOrDefault();
        }
        public DadosLivro CadastrarLivro(DadosLivro dados)
        {
            if (BuscarPorNome(dados) != null)
            {
                dados = null;
                return dados;
            }
            _context.Dados.Add(dados);
            _context.SaveChanges();
            return dados;
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
