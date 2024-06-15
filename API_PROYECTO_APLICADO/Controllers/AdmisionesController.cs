using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdmisionesController(Contexto _context) : ControllerBase
{
    // GET: api/Admisiones
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Admisiones>>> GetAdmisiones()
    {
        return await _context.Admisiones.ToListAsync();
    }

    // GET: api/Admisiones/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Admisiones>> GetAdmisiones(int id)
    {
        var admisiones = await _context.Admisiones.FindAsync(id);

        if (admisiones == null)
        {
            return NotFound();
        }

        return admisiones;
    }

    // POST: api/Admisiones
    [HttpPost]
    public async Task<ActionResult<Admisiones>> PostAdmisiones(Admisiones admisiones)
    {
        admisiones.AdmisioneId = 0;
        _context.Admisiones.Add(admisiones);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAdmisiones", new { id = admisiones.AdmisioneId }, admisiones);
    }

    // PUT: api/Admisiones/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAdmisiones(int id, Admisiones admisiones)
    {
        if (id != admisiones.AdmisioneId)
        {
            return BadRequest();
        }

        _context.Entry(admisiones).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AdmisionesExists(id))
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


    // DELETE: api/Admisiones/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAdmisiones(int id)
    {
        var admisiones = await _context.Admisiones.FindAsync(id);
        if (admisiones == null)
        {
            return NotFound();
        }

        _context.Admisiones.Remove(admisiones);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool AdmisionesExists(int id)
    {
        return _context.Admisiones.Any(e => e.AdmisioneId == id);
    }
}
