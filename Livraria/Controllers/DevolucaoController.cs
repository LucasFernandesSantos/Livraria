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
    public class DevolucaoController : Controller
    {
        private readonly LivroDAO _livroDAO;
        private readonly ReservaLivroDAO _reservaLivroDAO;
        private readonly ClienteDAO _clienteDAO;
        public DevolucaoController(ClienteDAO clienteDAO, LivroDAO livroDAO, ReservaLivroDAO reservaLivro)
        {
            _reservaLivroDAO = reservaLivro;
            _livroDAO = livroDAO;
            _clienteDAO = clienteDAO;
        }
        public IActionResult Devolucao()
        {

            return View(_reservaLivroDAO.ReservaDoCliente(Convert.ToInt32(HttpContext.Session.GetString("ClienteId"))));
        }

        public IActionResult DevolverReserva(int id)
        {
            ReservaLivro reserva = _reservaLivroDAO.BuscarPorID(id);
            DadosLivro dados = _livroDAO.BuscarPorID(reserva.LivroId);
            int idC = Convert.ToInt32(HttpContext.Session.GetString("ClienteId"));
            Cliente cliente = _clienteDAO.BuscarPorID(idC);
         
            cliente.StatusCliente = "Disponivel";
            dados.Status = "Disponivel";
            _clienteDAO.EditarCliente(cliente);
            _livroDAO.EditarLivro(dados);
            return RedirectToAction("Index", "Cliente");
        }

    }
}