using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class AdmController : Controller
    {
        private readonly ClienteDAO _clienteDAO;
        public static List<Cliente> listaCliente = new List<Cliente>();
        public AdmController(ClienteDAO clienteDAO)
        {
            _clienteDAO = clienteDAO;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListCliente()
        {
            ViewBag.DataHora = DateTime.Now;
            if (!listaCliente.Any())
            {
                return View(_clienteDAO.ListarTodos());
            }
            return View(listaCliente);

        }
        public IActionResult EditarCliente(int id)
        {
            var result = View(_clienteDAO.BuscarPorID(id));
            return result;
        }
        public IActionResult RemoverCliente(int id)
        {
            _clienteDAO.RemoverCliente(id);
            return RedirectToAction("ListCliente");
        }

        [HttpPost]
        public IActionResult EditarCliente(Cliente cliente)
        {
            _clienteDAO.EditarCliente(cliente);
            return RedirectToAction("ListCliente");
        }
      
    }
}