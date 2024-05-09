using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Dotnet.Context;
using API_Dotnet.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public ActionResult ObterPorId(int id)
        {
            var contato = _context.Contato.Find(id);

            if (contato == null)
                return NotFound();
            
            return Ok(contato);
        }

        public IActionResult Atualizar(int id, Contato contato)
        {
            
        }
    }
}