using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class ClienteController : Controller
    {
        private readonly LivroDAO _livroDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly ClienteDAO _clienteDAO;
        public ClienteController(ClienteDAO clienteDAO,LivroDAO livroDAO, CategoriaDAO categoriaDAO)
        {
            _categoriaDAO = categoriaDAO;
            _livroDAO = livroDAO;
            _clienteDAO = clienteDAO;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarLivro(int? id)
        {
            ViewBag.Categorias = _categoriaDAO.ListarTodos();
            if (id == null)
            {
                return View(_livroDAO.ListarLivroDisponivel());
            }
            return View(_livroDAO.ListarPorCategoria(id));

            
        }

        public IActionResult Detalhes(int id)
        {
            return View(_livroDAO.BuscarPorID(id));
        }
        public IActionResult Editar()
        {
            var resul = HttpContext.Session.GetString("ClienteId");
            var result = View(_clienteDAO.BuscarPorID(Convert.ToInt32(resul)));
            return result;
        }
        public IActionResult Excluir(int id)
        {
            var resul = HttpContext.Session.GetString("ClienteId");
            _clienteDAO.RemoverCliente(Convert.ToInt32(resul));
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            _clienteDAO.EditarCliente(cliente);
            return RedirectToAction("Index", "Home");
        }
    }
}