using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SemestrePlansController(Contexto _context) : ControllerBase
{
    // GET: api/SemestrePlans
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SemestrePlan>>> GetSemestrePlan()
    {
        return Ok(await _context.SemestrePlan.
            Include(d => d.DetalleSemestrePlan)
                .ThenInclude(dd => dd.DetalleDetalleSemestrePlan).
            ToListAsync());
    }

    // GET: api/SemestrePlans/5
    [HttpGet("{id}")]
    public async Task<ActionResult<SemestrePlan>> GetSemestrePlan(int id)
    {
        var semestrePlan = await _context.SemestrePlan.
            Include(d => d.DetalleSemestrePlan).
                ThenInclude(dd => dd.DetalleDetalleSemestrePlan)
                .FirstOrDefaultAsync(i => i.SemestrePlanId == id);

        if (semestrePlan == null)
        {
            return NotFound();
        }

        return Ok(semestrePlan);
    }

    // PUT: api/SemestrePlans/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSemestrePlan(int id, SemestrePlan semestrePlan)
    {
        if (id != semestrePlan.SemestrePlanId)
        {
            return BadRequest();
        }

        // Eliminar los detalles y subdetalles existentes
        var existingDetails = await _context.DetalleSemestrePlan
            .Where(dsp => dsp.SemestrePlanId == id)
            .Include(dsp => dsp.DetalleDetalleSemestrePlan)
            .ToListAsync();

        _context.DetalleDetalleSemestrePlan.RemoveRange(existingDetails.SelectMany(dsp => dsp.DetalleDetalleSemestrePlan));
        _context.DetalleSemestrePlan.RemoveRange(existingDetails);

        // Añadir los nuevos detalles y subdetalles
        foreach (var detalle in semestrePlan.DetalleSemestrePlan)
        {
            detalle.DetalleSemestrePlanId = 0;
            detalle.SemestrePlanId = id;

            foreach (var subDetalle in detalle.DetalleDetalleSemestrePlan)
            {
                subDetalle.DetalleDetalleSemestrePlanId = 0;
            }

            _context.DetalleSemestrePlan.Add(detalle);
        }

        _context.Entry(semestrePlan).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SemestrePlanExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return Ok(NoContent());
    }

    // POST: api/SemestrePlans
    [HttpPost]
    public async Task<ActionResult<SemestrePlan>> PostSemestrePlan(SemestrePlan semestrePlan)
    {
        _context.SemestrePlan.Add(semestrePlan);
        await _context.SaveChangesAsync();

        return Ok(CreatedAtAction("GetSemestrePlan", new { id = semestrePlan.SemestrePlanId }, semestrePlan));
    }

    // DELETE: api/SemestrePlans/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSemestrePlan(int id)
    {
        var semestrePlan = await _context.SemestrePlan
            .Include(sp => sp.DetalleSemestrePlan)
            .ThenInclude(dsp => dsp.DetalleDetalleSemestrePlan)
            .FirstOrDefaultAsync(sp => sp.SemestrePlanId == id);

        if (semestrePlan == null)
        {
            return NotFound();
        }

        _context.SemestrePlan.Remove(semestrePlan);
        await _context.SaveChangesAsync();

        return Ok(NoContent());
    }

    private bool SemestrePlanExists(int id)
    {
        return _context.SemestrePlan.Any(e => e.SemestrePlanId == id);
    }
}
