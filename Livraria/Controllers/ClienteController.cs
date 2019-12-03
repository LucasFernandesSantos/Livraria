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
        private readonly GeneroLivroDAO _generoLivroDAO;
        private readonly ClienteDAO _clienteDAO;
        public ClienteController(ClienteDAO clienteDAO,LivroDAO livroDAO, GeneroLivroDAO generoLivroDAO)
        {
            _generoLivroDAO = generoLivroDAO;
            _livroDAO = livroDAO;
            _clienteDAO = clienteDAO;
        }

        public IActionResult Index()    
        {
            return View();
        }

        public IActionResult ListarLivro(int? id)
        {
            Cliente cliente = _clienteDAO.BuscarPorID(Convert.ToInt32(HttpContext.Session.GetString("ClienteId")));
            ViewBag.Generos = _generoLivroDAO.ListarTodos();
            if (id == null)
            {
                if (cliente.StatusCliente.Equals("Indisponivel"))
                {
                 return View(_livroDAO.ListarLivroFake());
                }
                return View(_livroDAO.ListarLivroDisponivel());
            }
            return View(_livroDAO.ListarPorGeneros(id));    
        }

        public IActionResult Detalhes(int id)
        {
            HttpContext.Session.SetString("DadosLivroId", id.ToString());
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