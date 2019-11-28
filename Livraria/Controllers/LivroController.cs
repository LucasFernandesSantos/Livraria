using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        private readonly LivroDAO _livroDAO;
        public static List<Livro> listaLivro = new List<Livro>();
        public LivroController(LivroDAO livroDAO)
        {
            _livroDAO = livroDAO;
        }

        public IActionResult Livraria()
        {
            return View();
        }

        public IActionResult CadastrarLivro()
        {
            Livro livro = new Livro();
            if (TempData["Livro"] != null)
            {
                livro = JsonConvert.DeserializeObject<Livro>(TempData["Livro"].ToString());
            }
            return View(livro);
        }

        //[HttpPost]
        //public IActionResult CadastrarLivro(Livro livro)
        //{
        //    livro = _livroDAO.CadastrarLivro(livro);
        //    if (livro == null)
        //    {
        //        ModelState.AddModelError("", "Livro já cadastrado!");
        //        return View(livro);
        //    }
        //    return RedirectToAction("Index");
        //}

        public IActionResult ListLivro()
        {
            ViewBag.DataHora = DateTime.Now;
            if (!listaLivro.Any())
            {
                return View(_livroDAO.ListarTodos());
            }
            return View(listaLivro);
        }

        public IActionResult EditarLivro(int id)
        {
            var result = View(_livroDAO.BuscarPorID(id));
            return result;
        }
        public IActionResult RemoverLivro(int id)
        {
            _livroDAO.RemoverLivro(id);
            return RedirectToAction("ListLivro");
        }

        [HttpPost]
        public IActionResult EditarLivro(Livro livro)
        {
            _livroDAO.EditarLivro(livro);
            return RedirectToAction("ListLivro");
        }

        [HttpPost]
        public IActionResult BuscarLivro(String nome)
        {
            Livro livro = new Livro();
           string url = "https://www.googleapis.com/books/v1/volumes?q=intitle:" + nome;

            WebClient client = new WebClient();
            livro = JsonConvert.DeserializeObject<Livro>(client.DownloadString(url));
            TempData["Livro"] = JsonConvert.SerializeObject(livro);

            return RedirectToAction("Livraria");

        }

//        [HttpPost]
//        public IActionResult BuscarCep(string cep)
//        {
//            Enderec0 Enderec0 = new Enderec0();
//            string url = "http://cep.la/" + cep;
//            WebClient client = new WebClient();
//            Enderec0 = JsonConvert.DeserializeObject<Enderec0>(client.DownloadString(url));
//            TempData["Enderec0"] = JsonConvert.SerializeObject(Enderec0);

//            return RedirectToAction("Livraria");
//        }
  }
}