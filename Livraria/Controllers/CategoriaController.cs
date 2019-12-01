using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CategoriaDAO _categoriaDAO;

        public CategoriaController(CategoriaDAO categoriaDAO)
        {
            _categoriaDAO = categoriaDAO;
        }

        public IActionResult Index()
        {
            return View(_categoriaDAO.ListarTodos());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (_categoriaDAO.Cadastrar(categoria))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Essa categoria já existe!");
            }
            return View(categoria);
        }
    }
}
