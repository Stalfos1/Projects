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
    public class DetalleTagsController : ControllerBase
    {
        private readonly Context _context;

        public DetalleTagsController(Context context)
        {
            _context = context;
        }

        // GET: api/DetalleTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleTag>>> GetDetalleTags()
        {
          if (_context.DetalleTags == null)
          {
              return NotFound();
          }
            return await _context.DetalleTags.ToListAsync();
        }

        // GET: api/DetalleTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleTag>> GetDetalleTag(int id)
        {
          if (_context.DetalleTags == null)
          {
              return NotFound();
          }
            var detalleTag = await _context.DetalleTags.FindAsync(id);

            if (detalleTag == null)
            {
                return NotFound();
            }

            return detalleTag;
        }

        // PUT: api/DetalleTags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleTag(int id, DetalleTag detalleTag)
        {
            if (id != detalleTag.Id)
            {
                return BadRequest();
            }

            _context.Entry(detalleTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleTagExists(id))
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

        // POST: api/DetalleTags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleTag>> PostDetalleTag(DetalleTag detalleTag)
        {
          if (_context.DetalleTags == null)
          {
              return Problem("Entity set 'Context.DetalleTags'  is null.");
          }
            _context.DetalleTags.Add(detalleTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleTag", new { id = detalleTag.Id }, detalleTag);
        }

        // DELETE: api/DetalleTags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleTag(int id)
        {
            if (_context.DetalleTags == null)
            {
                return NotFound();
            }
            var detalleTag = await _context.DetalleTags.FindAsync(id);
            if (detalleTag == null)
            {
                return NotFound();
            }

            _context.DetalleTags.Remove(detalleTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleTagExists(int id)
        {
            return (_context.DetalleTags?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
