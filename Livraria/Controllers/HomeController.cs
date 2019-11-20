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
    public class HomeController : Controller
    {
        private readonly ClienteDAO _clienteDAO;

        public HomeController(ClienteDAO clienteDAO)
        {
            _clienteDAO = clienteDAO;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Cadastrar()
        {
            Cliente cliente = new Cliente();
            if (TempData["Cliente"] != null)
            {
                cliente = JsonConvert.DeserializeObject<Cliente>(TempData["Cliente"].ToString());
            }
            return View(cliente);
        }

        [HttpPost]
        public IActionResult BuscarCep(Cliente cliente)
        {
            try
            {
                string url = "https://viacep.com.br/ws/" + cliente.Endereco.Cep + "/json/";
                WebClient client = new WebClient();
                cliente.Endereco = JsonConvert.DeserializeObject<Endereco>(client.DownloadString(url));
                TempData["Cliente"] = JsonConvert.SerializeObject(cliente);
            }
            catch (Exception)
            {
                //Mostrar uma mensagem para o usuário
            }
            return RedirectToAction("Cadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (_clienteDAO.CadastrarCliente(cliente))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse cpf já está sendo usado!");
            }
            return View(cliente);
        }
    }
}