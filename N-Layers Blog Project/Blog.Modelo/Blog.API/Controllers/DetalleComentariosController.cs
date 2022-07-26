using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blog.DAL;
using Blog.Modelo;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleComentariosController : ControllerBase
    {
        private readonly Context _context;

        public DetalleComentariosController(Context context)
        {
            _context = context;
        }

        // GET: api/DetalleComentarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleComentario>>> GetDetalleComentarios()
        {
          if (_context.DetalleComentarios == null)
          {
              return NotFound();
          }
            return await _context.DetalleComentarios.ToListAsync();
        }

        // GET: api/DetalleComentarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleComentario>> GetDetalleComentario(int id)
        {
          if (_context.DetalleComentarios == null)
          {
              return NotFound();
          }
            var detalleComentario = await _context.DetalleComentarios.FindAsync(id);

            if (detalleComentario == null)
            {
                return NotFound();
            }

            return detalleComentario;
        }

        // PUT: api/DetalleComentarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleComentario(int id, DetalleComentario detalleComentario)
        {
            if (id != detalleComentario.Id)
            {
                return BadRequest();
            }

            _context.Entry(detalleComentario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleComentarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DetalleComentarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleComentario>> PostDetalleComentario(DetalleComentario detalleComentario)
        {
          if (_context.DetalleComentarios == null)
          {
              return Problem("Entity set 'Context.DetalleComentarios'  is null.");
          }
            _context.DetalleComentarios.Add(detalleComentario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleComentario", new { id = detalleComentario.Id }, detalleComentario);
        }

        // DELETE: api/DetalleComentarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleComentario(int id)
        {
            if (_context.DetalleComentarios == null)
            {
                return NotFound();
            }
            var detalleComentario = await _context.DetalleComentarios.FindAsync(id);
            if (detalleComentario == null)
            {
                return NotFound();
            }

            _context.DetalleComentarios.Remove(detalleComentario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleComentarioExists(int id)
        {
            return (_context.DetalleComentarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
