using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DetalleSemestrePlansController(Contexto _context) : ControllerBase
{
    // GET: api/DetalleSemestrePlans/5
    [HttpGet("{id}")]
    public async Task<ActionResult<DetalleSemestrePlan>> GetDetalleSemestrePlan(int id)
    {
        var detalleSemestrePlan = await _context.DetalleSemestrePlan.
            Include(p => p.DetalleDetalleSemestrePlan).
                FirstOrDefaultAsync(i => i.DetalleSemestrePlanId == id);

        if (detalleSemestrePlan == null)
        {
            return NotFound();
        }

        return detalleSemestrePlan;
    }

    // PUT: api/DetalleSemestrePlans/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDetalleSemestrePlan(int id, DetalleSemestrePlan detalleSemestrePlan)
    {
        if (id != detalleSemestrePlan.DetalleSemestrePlanId)
        {
            return BadRequest();
        }

        await _context.DetalleDetalleSemestrePlan.
            Where(i => i.DetalleDetalleSemestrePlanId == id)
            .ExecuteDeleteAsync();

        foreach (var item in detalleSemestrePlan.DetalleDetalleSemestrePlan)
        {
            item.DetalleDetalleSemestrePlanId = 0;
            item.DetalleSemestrePlanId = id;
            _context.DetalleDetalleSemestrePlan.Add(item);
        }

        _context.Entry(detalleSemestrePlan).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DetalleSemestrePlanExists(id))
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

    // POST: api/DetalleSemestrePlans
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<DetalleSemestrePlan>> PostDetalleSemestrePlan(DetalleSemestrePlan detalleSemestrePlan)
    {
        _context.DetalleSemestrePlan.Add(detalleSemestrePlan);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDetalleSemestrePlan", new { id = detalleSemestrePlan.DetalleSemestrePlanId }, detalleSemestrePlan);
    }

    // DELETE: api/DetalleSemestrePlans/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDetalleSemestrePlan(int id)
    {
        var detalleSemestrePlan = await _context.DetalleSemestrePlan.FindAsync(id);
        if (detalleSemestrePlan == null)
        {
            return NotFound();
        }

        await _context.DetalleDetalleSemestrePlan.
            Where(i => i.DetalleDetalleSemestrePlanId == id)
            .ExecuteDeleteAsync();

        _context.DetalleSemestrePlan.Remove(detalleSemestrePlan);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DetalleSemestrePlanExists(int id)
    {
        return _context.DetalleSemestrePlan.Any(e => e.DetalleSemestrePlanId == id);
    }
}
