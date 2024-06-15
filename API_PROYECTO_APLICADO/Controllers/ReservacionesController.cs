using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservacionesController(Contexto _context) : ControllerBase
{
    // GET: api/Reservaciones
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Reservaciones>>> GetReservaciones()
    {
        return await _context.Reservaciones.ToListAsync();
    }

    // GET: api/Reservaciones/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Reservaciones>> GetReservaciones(int id)
    {
        var reservaciones = await _context.Reservaciones.FindAsync(id);

        if (reservaciones == null)
        {
            return NotFound();
        }

        return reservaciones;
    }

    // POST: api/Reservaciones
    [HttpPost]
    public async Task<ActionResult<Reservaciones>> PostReservaciones(Reservaciones reservaciones)
    {
        reservaciones.ReservacionId = 0;
        _context.Reservaciones.Add(reservaciones);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetReservaciones", new { id = reservaciones.ReservacionId }, reservaciones);
    }

    // PUT: api/Reservaciones/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutReservaciones(int id, Reservaciones reservaciones)
    {
        if (id != reservaciones.ReservacionId)
        {
            return BadRequest();
        }

        _context.Entry(reservaciones).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ReservacionesExists(id))
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

    // DELETE: api/Reservaciones/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReservaciones(int id)
    {
        var reservaciones = await _context.Reservaciones.FindAsync(id);
        if (reservaciones == null)
        {
            return NotFound();
        }

        _context.Reservaciones.Remove(reservaciones);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ReservacionesExists(int id)
    {
        return _context.Reservaciones.Any(e => e.ReservacionId == id);
    }
}
