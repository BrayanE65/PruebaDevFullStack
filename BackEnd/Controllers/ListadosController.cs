using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListadosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ListadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Listados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Listado>>> GetListados()
        {
            return await _context.Listados.ToListAsync();
        }

        // GET: api/Listados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Listado>> GetListado(int id)
        {
            var listado = await _context.Listados.FindAsync(id);

            if (listado == null)
            {
                return NotFound();
            }

            return listado;
        }

        // PUT: api/Listados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListado(int id, Listado listado)
        {
            if (id != listado.ID)
            {
                return BadRequest();
            }

            _context.Entry(listado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListadoExists(id))
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

        // POST: api/Listados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Listado>> PostListado(Listado listado)
        {
            _context.Listados.Add(listado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListado", new { id = listado.ID }, listado);
        }

        // DELETE: api/Listados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListado(int id)
        {
            var listado = await _context.Listados.FindAsync(id);
            if (listado == null)
            {
                return NotFound();
            }

            _context.Listados.Remove(listado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListadoExists(int id)
        {
            return _context.Listados.Any(e => e.ID == id);
        }
    }
}
