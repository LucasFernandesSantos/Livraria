using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    public class GeneroLivroController : Controller
    {
        private readonly GeneroLivroDAO _generoLivroDAO;

        public GeneroLivroController(GeneroLivroDAO generoLivroDAO)
        {
            _generoLivroDAO = generoLivroDAO;
        }

        public IActionResult ListaGeneros()
        {
            return View(_generoLivroDAO.ListarTodos());
        }

        public IActionResult CadastrarGenero()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarGenero(GeneroLivro generoLivro)
        {
            if (ModelState.IsValid)
            {
                if (_generoLivroDAO.CadastrarGenero(generoLivro))
                {
                    return RedirectToAction("ListaGeneros");
                }
                ModelState.AddModelError("", "Esse gênero já está cadastrado.");
            }
            return View(generoLivro);
        }

        public IActionResult RemoverGenero(int id)
        {
            _generoLivroDAO.RemoverGenero(id);
            return RedirectToAction("ListaGeneros");
        }

        public IActionResult EditarGenero(int id)
        {
            var result = View(_generoLivroDAO.BuscarPorId(id));
            return result;
        }
        [HttpPost]
        public IActionResult EditarGenero(GeneroLivro generoLivro)
        {
            _generoLivroDAO.EditarGenero(generoLivro);
            return RedirectToAction("ListaGeneros");
        }
    } 
}
