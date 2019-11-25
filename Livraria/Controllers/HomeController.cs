    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Http;
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
        [HttpPost]
        public IActionResult Index(string cpf, string senha)
        {
            Cliente c = new Cliente();
            c = _clienteDAO.AutenticarLogin(cpf, senha);
            Adm adm = new Adm();
            if (c != null)
            {
                ModelState.AddModelError("", "Login OK!");
                HttpContext.Session.SetString("ClienteId", c.ClienteId.ToString());
                return RedirectToAction("Index", "Cliente"); ;
            }
            else if (cpf.ToUpper().Equals(adm.Login) && senha.ToUpper().Equals(adm.Senha))
            {
                ModelState.AddModelError("", "Login Adm!");
                return RedirectToAction("Index", "Adm");
            }
            else
            {
                ModelState.AddModelError("", "Login Invalido!");
                ViewBag.Alerta = true;
                return View();
            }
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
            cliente = _clienteDAO.CadastrarCliente(cliente);
            if (cliente == null)
            {
                ModelState.AddModelError("", "Cliente já cadastrado!");
                return View(cliente);
            }
            return RedirectToAction("Index");
        }
    }
}