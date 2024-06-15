using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FacturacionesController(Contexto _context) : ControllerBase
{
    // GET: api/Facturaciones
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Facturaciones>>> GetFacturaciones()
    {
        return await _context.Facturaciones.ToListAsync();
    }

    // GET: api/Facturaciones/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Facturaciones>> GetFacturaciones(int id)
    {
        var facturaciones = await _context.Facturaciones.FindAsync(id);

        if (facturaciones == null)
        {
            return NotFound();
        }

        return facturaciones;
    }


    // POST: api/Facturaciones
    [HttpPost]
    public async Task<ActionResult<Facturaciones>> PostFacturaciones(Facturaciones facturaciones)
    {
        facturaciones.FacturacionId = 0;
        _context.Facturaciones.Add(facturaciones);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetFacturaciones", new { id = facturaciones.FacturacionId }, facturaciones);
    }

    // PUT: api/Facturaciones/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutFacturaciones(int id, Facturaciones facturaciones)
    {
        if (id != facturaciones.FacturacionId)
        {
            return BadRequest();
        }

        _context.Entry(facturaciones).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FacturacionesExists(id))
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

    // DELETE: api/Facturaciones/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFacturaciones(int id)
    {
        var facturaciones = await _context.Facturaciones.FindAsync(id);
        if (facturaciones == null)
        {
            return NotFound();
        }

        _context.Facturaciones.Remove(facturaciones);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FacturacionesExists(int id)
    {
        return _context.Facturaciones.Any(e => e.FacturacionId == id);
    }
}
