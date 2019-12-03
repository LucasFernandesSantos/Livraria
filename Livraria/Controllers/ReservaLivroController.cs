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
    public class ReservaLivroController : Controller
    {
        private readonly LivroDAO _livroDAO;
        private readonly ReservaLivroDAO _reservaLivroDAO;
        private readonly ClienteDAO _clienteDAO;
        public ReservaLivroController(ClienteDAO clienteDAO, LivroDAO livroDAO, ReservaLivroDAO reservaLivro)
        {
            _reservaLivroDAO = reservaLivro;
            _livroDAO = livroDAO;
            _clienteDAO = clienteDAO;
        }
        public IActionResult ReservaLivro()
        {

            return View();
        }
        public IActionResult SalvarReservaLivro(ReservaLivro reserva)
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("DadosLivroId"));
            DadosLivro dados = _livroDAO.BuscarPorID(id);
            int idC = Convert.ToInt32(HttpContext.Session.GetString("ClienteId"));
            Cliente cliente = _clienteDAO.BuscarPorID(idC);
            reserva.Cliente = cliente;
            reserva.DadosLivro = dados;
            reserva.LivroId = dados.DadosLivroId;
            reserva.Cliente.StatusCliente = "Indisponivel";
            reserva.DadosLivro.Status = "Indisponivel";
            _reservaLivroDAO.UpdateReserva(reserva);
            return RedirectToAction("Index","Cliente");
        }

    }
}
