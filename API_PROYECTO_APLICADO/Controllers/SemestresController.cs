using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SemestresController(Contexto _context) : ControllerBase
{
    // GET: api/Semestres
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Semestres>>> GetSemestres()
    {
        return await _context.Semestres.ToListAsync();
    }

    // GET: api/Semestres/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Semestres>> GetSemestres(int id)
    {
        var semestres = await _context.Semestres.FindAsync(id);

        if (semestres == null)
        {
            return NotFound();
        }

        return semestres;
    }

    // POST: api/Semestres
    [HttpPost]
    public async Task<ActionResult<Semestres>> PostSemestres(Semestres semestres)
    {
        semestres.SemestreId = 0;
        _context.Semestres.Add(semestres);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetSemestres", new { id = semestres.SemestreId }, semestres);
    }

    // PUT: api/Semestres/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSemestres(int id, Semestres semestres)
    {
        if (id != semestres.SemestreId)
        {
            return BadRequest();
        }

        _context.Entry(semestres).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SemestresExists(id))
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

    // DELETE: api/Semestres/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSemestres(int id)
    {
        var semestres = await _context.Semestres.FindAsync(id);
        if (semestres == null)
        {
            return NotFound();
        }

        _context.Semestres.Remove(semestres);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool SemestresExists(int id)
    {
        return _context.Semestres.Any(e => e.SemestreId == id);
    }
}
