using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;
using Shared.Dtos;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InventarioReservasController(Contexto _context) : ControllerBase
{

    // GET: api/InventarioReservas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<InventarioReservas>>> GetInventarioReservas()
    {
        return await _context.InventarioReservas.Include(p => p.InventarioReservacionesDetalle).ToListAsync();
    }

    // GET: api/InventarioReservas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<InventarioReservas>> GetInventarioReservas(int id)
    {
        var inventarioReservas = await _context.InventarioReservas
            .Include(p => p.InventarioReservacionesDetalle)
                .FirstOrDefaultAsync(p => p.InventarioReservaId == id);

        if (inventarioReservas == null)
        {
            return NotFound();
        }

        return inventarioReservas;
    }

    // PUT: api/InventarioReservas/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutInventarioReservas(int id, InventarioReservas inventarioReservas)
    {
        if (id != inventarioReservas.InventarioReservaId)
        {
            return BadRequest();
        }

        _context.Entry(inventarioReservas).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InventarioReservasExists(id))
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

    // POST: api/InventarioReservas
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<InventarioReservas>> PostInventarioReservas(InventarioReservas inventarioReservas)
    {
        _context.InventarioReservas.Add(inventarioReservas);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetInventarioReservas", new { id = inventarioReservas.InventarioReservaId }, inventarioReservas);
    }

    // DELETE: api/InventarioReservas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteInventarioReservas(int id)
    {
        var inventarioReservas = await _context.InventarioReservas.FindAsync(id);
        if (inventarioReservas == null)
        {
            return NotFound();
        }

        _context.InventarioReservas.Remove(inventarioReservas);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool InventarioReservasExists(int id)
    {
        return _context.InventarioReservas.Any(e => e.InventarioReservaId == id);
    }
}
