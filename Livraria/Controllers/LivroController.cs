using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        private readonly LivroDAO _livroDAO;
        private readonly GeneroLivroDAO _generoLivroDAO;
        private readonly IHostingEnvironment _hosting;
        public static List<Livro> listaLivro = new List<Livro>();
        public LivroController(LivroDAO livroDAO, GeneroLivroDAO generoLivroDAO, IHostingEnvironment hosting)
        {
            _livroDAO = livroDAO;
            _generoLivroDAO = generoLivroDAO;
            _hosting = hosting;
        }
        public IActionResult ListarLivro()
        {

            if (!listaLivro.Any())
            {
                return View(_livroDAO.ListarLivro());
            }
            return View(listaLivro);

        }
        public IActionResult RemoverLivro(int id)
        {
            _livroDAO.RemoverLivro(id);
            return RedirectToAction("ListarLivro");
        }
        public IActionResult CadastrarLivro()
        {
            DadosLivro dados = new DadosLivro();
            if (TempData["DadosLivro"] != null)
            {
                dados = JsonConvert.DeserializeObject<DadosLivro>(TempData["DadosLivro"].ToString());
                ViewBag.Generos = new SelectList(_generoLivroDAO.ListarTodos(), "GeneroLivroId", "Nome");
            }
            return View(dados);
        }


        public IActionResult EditarLivro(int id)
        {
            var result = View(_livroDAO.BuscarPorID(id));
            return result;
        }
        [HttpPost]
        public IActionResult EditarLivro(DadosLivro dados)
        {
            _livroDAO.EditarLivro(dados);
            return RedirectToAction("ListarLivro");
        }

        [HttpPost]
        public IActionResult CadastrarLivro(DadosLivro dados, int drpGeneros, IFormFile fupImagem)
        {
            ViewBag.Generos = new SelectList(_generoLivroDAO.ListarTodos(), "GeneroLivroId", "Nome");

            if (ModelState.IsValid)
            {
                if (fupImagem != null)
                {
                    string arquivo = Guid.NewGuid().ToString() + Path.GetExtension(fupImagem.FileName);
                    string caminho = Path.Combine(_hosting.WebRootPath, "livrariaimagens", arquivo);
                    fupImagem.CopyTo(new FileStream(caminho, FileMode.Create));
                    dados.Imagem = arquivo;
                }
                else
                {
                    dados.Imagem = "CAPANULL2.png";

                }

                dados.GeneroLivro = _generoLivroDAO.BuscarPorId(drpGeneros);
                if (_livroDAO.CadastrarLivro(dados))
                {
                    return RedirectToAction("ListarLivro");
                }
                ModelState.AddModelError("", "Esse produto já existe!");
                return View(dados);
            }
            ViewBag.salvar = "show";
            return View(dados);
        }

        [HttpPost]
        public IActionResult BuscarLivro(string nome)
        {
            Livro livro = new Livro();
            DadosLivro dados = new DadosLivro();
            string url = "https://www.googleapis.com/books/v1/volumes?q=intitle:" + nome;

            WebClient client = new WebClient();
            livro = JsonConvert.DeserializeObject<Livro>(client.DownloadString(url));

            for (int i = 0; 1 < livro.items.Count; i++)
            {
                dados.Authors = livro.items[0].volumeInfo.Authors;
                dados.Title = livro.items[0].volumeInfo.Title;
                dados.Publisher = livro.items[0].volumeInfo.Publisher;
                dados.PublishedDate = livro.items[0].volumeInfo.PublishedDate;
                dados.Description = livro.items[0].volumeInfo.Description;
                break;
            }
      
            TempData["DadosLivro"] = JsonConvert.SerializeObject(dados);

            return RedirectToAction("CadastrarLivro");

        }
    }
}
