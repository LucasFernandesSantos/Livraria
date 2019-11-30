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
    public class GeneroController : Controller
    {
        private readonly GeneroDAO _generoDAO;

        public GeneroController(GeneroDAO categoriaDAO)
        {
            _generoDAO = categoriaDAO;
        }

        public IActionResult ListaGeneros()
        {
            return View(_generoDAO.ListarTodosGeneros());
        }
        public IActionResult CadastrarGenero()
        {
            Genero genero = new Genero();
            return View(genero);
        }

        [HttpPost]
        public IActionResult CadastrarGenero(Genero genero)
        {
            genero = _generoDAO.CadastrarGenero(genero);
            if (genero == null)

            {
                ModelState.AddModelError("", "Genero já cadastrado!");
                return View(genero);
            }
            return RedirectToAction("ListaGeneros");
        }
        public IActionResult EditarGenero(int id)
        {
            var result = View(_generoDAO.BuscarGeneroPorId(id));
            return result;
        }

        [HttpPost]
        public IActionResult EditarGenero(Genero genero)
        {
            _generoDAO.EditarGenero(genero);
            return RedirectToAction("ListaGeneros");
        }

        public IActionResult RemoverGenero(int id)
        {
            _generoDAO.RemoverGenero(id);
            return RedirectToAction("ListaGeneros");

        }
    }
}
