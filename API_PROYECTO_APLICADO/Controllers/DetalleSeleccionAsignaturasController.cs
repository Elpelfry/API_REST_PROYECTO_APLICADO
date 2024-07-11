using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;
using Shared.Dtos;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DetalleSeleccionAsignaturasController(Contexto _context) : ControllerBase
{

    // GET: api/DetalleSeleccionAsignaturas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<DetalleSeleccionAsignatura>> GetDetalleSeleccionAsignatura(int id)
    {
        var detalleSeleccionAsignatura = await _context.DetalleSeleccionAsignatura.FindAsync(id);

        if (detalleSeleccionAsignatura == null)
        {
            return NotFound();
        }

        return Ok(detalleSeleccionAsignatura);
    }
    
    // PUT: api/DetalleSeleccionAsignaturas/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDetalleSeleccionAsignatura(int id, DetalleSeleccionAsignatura detalleSeleccionAsignatura)
    {
        if (id != detalleSeleccionAsignatura.DetalleSeleccionAsignaturaId)
        {
            return BadRequest();
        }

        _context.Entry(detalleSeleccionAsignatura).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DetalleSeleccionAsignaturaExists(id))
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

    // POST: api/DetalleSeleccionAsignaturas
    [HttpPost]
    public async Task<ActionResult<DetalleSeleccionAsignatura>> PostDetalleSeleccionAsignatura(DetalleSeleccionAsignatura detalleSeleccionAsignatura)
    {
        _context.DetalleSeleccionAsignatura.Add(detalleSeleccionAsignatura);
        await _context.SaveChangesAsync();

        return Ok(CreatedAtAction("GetDetalleSeleccionAsignatura", new { id = detalleSeleccionAsignatura.DetalleSeleccionAsignaturaId }, detalleSeleccionAsignatura));
    }
    [HttpPatch("{estado}/{id}")]
    public async Task<ActionResult> ModificarDetalleEstado( string estado, int id)
    {
        var detalleSeleccionAsignatura = await _context.DetalleSeleccionAsignatura.FindAsync(id);

        if (detalleSeleccionAsignatura == null)
        {
            return NotFound();
        }

        detalleSeleccionAsignatura.Estado = estado;
        _context.Entry(detalleSeleccionAsignatura).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return Ok(detalleSeleccionAsignatura);
    }

    // DELETE: api/DetalleSeleccionAsignaturas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDetalleSeleccionAsignatura(int id)
    {
        var detalleSeleccionAsignatura = await _context.DetalleSeleccionAsignatura.FindAsync(id);
        if (detalleSeleccionAsignatura == null)
        {
            return NotFound();
        }

        _context.DetalleSeleccionAsignatura.Remove(detalleSeleccionAsignatura);
        await _context.SaveChangesAsync();

        return Ok(NoContent());
    }

    private bool DetalleSeleccionAsignaturaExists(int id)
    {
        return _context.DetalleSeleccionAsignatura.Any(e => e.DetalleSeleccionAsignaturaId == id);
    }
}
