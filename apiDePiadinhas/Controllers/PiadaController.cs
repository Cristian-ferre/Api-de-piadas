using Microsoft.AspNetCore.Mvc;
using apiDePiadinhas.Entities;
using apiDePiadinhas.Context;

namespace apiDePiadinhas.Controllers
{

    [ApiController]
    [Route("[controller]")] 
    public class PiadaController : ControllerBase
    {
        private readonly PiadasContext _context ;

        public PiadaController(PiadasContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarPiada(Piadas Piadas){
            _context.Add(Piadas);
            _context.SaveChanges();
            return Ok(Piadas);
        }
        [HttpGet("{id}")]
        public IActionResult PegarPiada(int id){
            var piadaBanco = _context.Piadas.Find(id);
            if(piadaBanco == null) return NotFound();
            
            return Ok(piadaBanco);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPiada(int id, Piadas piada){
            var piadaBanco = _context.Piadas.Find(id);
            if(piadaBanco == null) return NotFound();

            piadaBanco.Description = piada.Description;
            piadaBanco.Resp = piada.Resp;
            _context.SaveChanges();
            return Ok(piadaBanco);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletarPiada (int id)
        {
            var piadaBanco = _context.Piadas.Find(id);
            if(piadaBanco == null)
            return NotFound();

            _context.Piadas.Remove(piadaBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}