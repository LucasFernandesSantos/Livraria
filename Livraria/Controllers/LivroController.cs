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
                    dados.Imagem = "leedopai.png";

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
            //foreach (var item in livro.items)
            //{
            //    dados.Authors = item.volumeInfo.Authors;
            //    dados.Title = item.volumeInfo.Title;
            //    dados.Publisher = item.volumeInfo.Publisher;
            //    dados.PublishedDate = item.volumeInfo.PublishedDate;
            //    dados.Description = item.volumeInfo.Description;
            //}
            TempData["DadosLivro"] = JsonConvert.SerializeObject(dados);

            return RedirectToAction("CadastrarLivro");

        }
    }
}

//      //[HttpPost]
//        //public IActionResult CadastrarLivro(Livro livro)
//        //{
//        //    livro = _livroDAO.CadastrarLivro(livro);
//        //    if (livro == null)
//        //    {
////        //        ModelState.AddModelError("", "Livro já cadastrado!");
////        //        return View(livro);
////        //    }
////        //    return RedirectToAction("Index");
////        //}

//        public IActionResult ListLivro()
//        {
//            ViewBag.DataHora = DateTime.Now;
//            if (!listaLivro.Any())
//            {
//                return View(_livroDAO.ListarTodos());
//            }
//            return View(listaLivro);
//        }

//        public IActionResult EditarLivro(int id)
//        {
//            var result = View(_livroDAO.BuscarPorID(id));
//            return result;
//        }
//        public IActionResult RemoverLivro(int id)
//        {
//            _livroDAO.RemoverLivro(id);
//            return RedirectToAction("ListLivro");
//        }

//        [HttpPost]
//        public IActionResult EditarLivro(Livro livro)
//        {
//            _livroDAO.EditarLivro(livro);
//            return RedirectToAction("ListLivro");
//        }

//        [HttpPost]
//        public IActionResult BuscarLivro(String nome)
//        {
//            Livro livro = new Livro();
//           string url = "https://www.googleapis.com/books/v1/volumes?q=intitle:" + nome;

//            WebClient client = new WebClient();
//            livro = JsonConvert.DeserializeObject<Livro>(client.DownloadString(url));
//            TempData["Livro"] = JsonConvert.SerializeObject(livro);

//            return RedirectToAction("Livraria");

//        }

////        [HttpPost]
////        public IActionResult BuscarCep(string cep)
////        {
////            Enderec0 Enderec0 = new Enderec0();
////            string url = "http://cep.la/" + cep;
////            WebClient client = new WebClient();
////            Enderec0 = JsonConvert.DeserializeObject<Enderec0>(client.DownloadString(url));
////            TempData["Enderec0"] = JsonConvert.SerializeObject(Enderec0);

////            return RedirectToAction("Livraria");
////        }
//  }
//}