using Livraria.DAO;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    [Route("api/Livro")]
    [ApiController]
    public class LivroAPIController : ControllerBase
    {
        private readonly LivroDAO _LivroDAO;
        public LivroAPIController(LivroDAO livroDAO)
        {
            _LivroDAO = livroDAO;
        }
        //mec
        [HttpGet]
        [Route("BuscarPorGenero/{id}")]
        public IActionResult BuscarPorGenero(int id)
        {
            List<DadosLivro> livros = _LivroDAO.ListarPorGeneros(id);
            if (livros.Count > 0)
            {
                return Ok(livros);
            }
            return NotFound(new { msg = "Não existem livros!" });
        }
        //mec
        [HttpPost]
        [Route("CadastrarLivro")]
        public IActionResult Cadastrar(DadosLivro dados)
        {
            if (ModelState.IsValid)
            {
                if (_LivroDAO.CadastrarLivro(dados))
                {
                    return Created("", dados);
                }
                return Conflict(new { msg = "Esse livro já existe!" });
            }
            return BadRequest(ModelState);
        }
        //mec
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_LivroDAO.ListarTodos());
        }
    }

}
