using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeleccionAsignaturasController(Contexto _context) : ControllerBase
{
    // GET: api/SeleccionAsignaturas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeleccionAsignaturas>>> GetSeleccionAsignaturas()
    {
        return await _context.SeleccionAsignaturas.Include(i => i.DetalleSeleccionAsignaturas).ToListAsync();
    }

    // GET: api/SeleccionAsignaturas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<SeleccionAsignaturas>> GetSeleccionAsignaturas(int id)
    {
        var seleccionAsignaturas = await _context.SeleccionAsignaturas.Include(i => i.DetalleSeleccionAsignaturas)
            .FirstOrDefaultAsync(a => a.SeleccionAsignaturaId == id);

        if (seleccionAsignaturas == null)
        {
            return NotFound();
        }

        return seleccionAsignaturas;
    }

    // POST: api/SeleccionAsignaturas
    [HttpPost]
    public async Task<ActionResult<SeleccionAsignaturas>> PostSeleccionAsignaturas(SeleccionAsignaturas seleccionAsignaturas)
    {
        seleccionAsignaturas.SeleccionAsignaturaId = 0;
        _context.SeleccionAsignaturas.Add(seleccionAsignaturas);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetSeleccionAsignaturas", new { id = seleccionAsignaturas.SeleccionAsignaturaId }, seleccionAsignaturas);
    }

    // PUT: api/SeleccionAsignaturas/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSeleccionAsignaturas(int id, SeleccionAsignaturas seleccionAsignaturas)
    {
        if (id != seleccionAsignaturas.SeleccionAsignaturaId)
        {
            return BadRequest();
        }

        _context.Entry(seleccionAsignaturas).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SeleccionAsignaturasExists(id))
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

    // DELETE: api/SeleccionAsignaturas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSeleccionAsignaturas(int id)
    {
        var seleccionAsignaturas = await _context.SeleccionAsignaturas.FindAsync(id);
        if (seleccionAsignaturas == null)
        {
            return NotFound();
        }

        _context.SeleccionAsignaturas.Remove(seleccionAsignaturas);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool SeleccionAsignaturasExists(int id)
    {
        return _context.SeleccionAsignaturas.Any(e => e.SeleccionAsignaturaId == id);
    }
}
