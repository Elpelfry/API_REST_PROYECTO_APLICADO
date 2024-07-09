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
public class DetalleDetalleSemestrePlansController(Contexto _context) : ControllerBase
{
    // GET: api/DetalleDetalleSemestrePlans/5
    [HttpGet("{id}")]
    public async Task<ActionResult<DetalleDetalleSemestrePlan>> GetDetalleDetalleSemestrePlan(int id)
    {
        var detalleDetalleSemestrePlan = await _context.DetalleDetalleSemestrePlan.FindAsync(id);

        if (detalleDetalleSemestrePlan == null)
        {
            return NotFound();
        }

        return detalleDetalleSemestrePlan;
    }

    // PUT: api/DetalleDetalleSemestrePlans/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDetalleDetalleSemestrePlan(int id, DetalleDetalleSemestrePlan detalleDetalleSemestrePlan)
    {
        if (id != detalleDetalleSemestrePlan.DetalleDetalleSemestrePlanId)
        {
            return BadRequest();
        }

        _context.Entry(detalleDetalleSemestrePlan).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DetalleDetalleSemestrePlanExists(id))
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

    // POST: api/DetalleDetalleSemestrePlans
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<DetalleDetalleSemestrePlan>> PostDetalleDetalleSemestrePlan(DetalleDetalleSemestrePlan detalleDetalleSemestrePlan)
    {
        _context.DetalleDetalleSemestrePlan.Add(detalleDetalleSemestrePlan);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDetalleDetalleSemestrePlan", new { id = detalleDetalleSemestrePlan.DetalleDetalleSemestrePlanId }, detalleDetalleSemestrePlan);
    }

    // DELETE: api/DetalleDetalleSemestrePlans/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDetalleDetalleSemestrePlan(int id)
    {
        var detalleDetalleSemestrePlan = await _context.DetalleDetalleSemestrePlan.FindAsync(id);
        if (detalleDetalleSemestrePlan == null)
        {
            return NotFound();
        }

        _context.DetalleDetalleSemestrePlan.Remove(detalleDetalleSemestrePlan);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DetalleDetalleSemestrePlanExists(int id)
    {
        return _context.DetalleDetalleSemestrePlan.Any(e => e.DetalleDetalleSemestrePlanId == id);
    }
}
