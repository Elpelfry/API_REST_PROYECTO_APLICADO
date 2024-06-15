using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarrerasController(Contexto _context) : ControllerBase
{
    // GET: api/Carreras
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Carreras>>> GetCarreras()
    {
        return await _context.Carreras.ToListAsync();
    }

    // GET: api/Carreras/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Carreras>> GetCarreras(int id)
    {
        var carreras = await _context.Carreras.FindAsync(id);

        if (carreras == null)
        {
            return NotFound();
        }

        return carreras;
    }


    // POST: api/Carreras
    [HttpPost]
    public async Task<ActionResult<Carreras>> PostCarreras(Carreras carreras)
    {
        carreras.CarreraId = 0;
        _context.Carreras.Add(carreras);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetCarreras", new { id = carreras.CarreraId }, carreras);
    }

    // PUT: api/Carreras/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCarreras(int id, Carreras carreras)
    {
        if (id != carreras.CarreraId)
        {
            return BadRequest();
        }

        _context.Entry(carreras).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CarrerasExists(id))
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

    // DELETE: api/Carreras/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCarreras(int id)
    {
        var carreras = await _context.Carreras.FindAsync(id);
        if (carreras == null)
        {
            return NotFound();
        }

        _context.Carreras.Remove(carreras);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CarrerasExists(int id)
    {
        return _context.Carreras.Any(e => e.CarreraId == id);
    }
}
