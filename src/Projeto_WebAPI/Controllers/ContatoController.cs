using Microsoft.AspNetCore.Mvc;
using Projeto_WebAPI.Context;
using Projeto_WebAPI.Entities;

namespace Projeto_WebAPI.Controllers
{
    [ApiController]
    [Route("api/contato")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost("Criar")]
        public IActionResult Criar(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var contatos = _context.Contatos.ToList();

            if (contatos is null)
            {
                return NotFound();
            }

            return Ok(contatos);
        }

        [HttpGet("ObterPorId/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato is null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos
                .Where(c => c.Nome.Contains(nome))
                .ToList();

            return Ok(contatos);
        }

        [HttpPut("Atualizar/{id}")]
        public IActionResult Atualizar(int id, Contato contatoAtualizado)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco is null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contatoAtualizado.Nome;
            contatoBanco.Telefone = contatoAtualizado.Telefone;
            contatoBanco.Ativo = contatoAtualizado.Ativo;

            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco is null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}