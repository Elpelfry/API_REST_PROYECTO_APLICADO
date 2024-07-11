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
public class DetalleInventarioReservasController(Contexto _context) : ControllerBase
{
    // GET: api/DetalleInventarioReservas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<DetalleInventarioReserva>> GetDetalleInventarioReserva(int id)
    {
        var detalleInventarioReserva = await _context.DetalleInventarioReservas.FindAsync(id);

        if (detalleInventarioReserva == null)
        {
            return NotFound();
        }

        return Ok(detalleInventarioReserva);
    }

    // PUT: api/DetalleInventarioReservas/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDetalleInventarioReserva(int id, DetalleInventarioReserva detalleInventarioReserva)
    {
        if (id != detalleInventarioReserva.DetalleInventarioReservaId)
        {
            return BadRequest();
        }

        _context.Entry(detalleInventarioReserva).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DetalleInventarioReservaExists(id))
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

    // POST: api/DetalleInventarioReservas
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<DetalleInventarioReserva>> PostDetalleInventarioReserva(DetalleInventarioReserva detalleInventarioReserva)
    {
        _context.DetalleInventarioReservas.Add(detalleInventarioReserva);
        await _context.SaveChangesAsync();

        return Ok(CreatedAtAction("GetDetalleInventarioReserva", new { id = detalleInventarioReserva.DetalleInventarioReservaId }, detalleInventarioReserva));
    }

    [HttpPatch("{estado}/{id}")]
    public async Task<ActionResult> CambiarEstado(int id, bool estado)
    {
        var detalleInventarioReserva = await _context.DetalleInventarioReservas.FindAsync(id);

        if (detalleInventarioReserva == null)
        {
            return NotFound();
        }

        detalleInventarioReserva.Estado = estado;
        _context.Entry(detalleInventarioReserva).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return Ok(detalleInventarioReserva);
    }

    // DELETE: api/DetalleInventarioReservas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDetalleInventarioReserva(int id)
    {
        var detalleInventarioReserva = await _context.DetalleInventarioReservas.FindAsync(id);
        if (detalleInventarioReserva == null)
        {
            return NotFound();
        }

        _context.DetalleInventarioReservas.Remove(detalleInventarioReserva);
        await _context.SaveChangesAsync();

        return Ok(NoContent());
    }

    private bool DetalleInventarioReservaExists(int id)
    {
        return _context.DetalleInventarioReservas.Any(e => e.DetalleInventarioReservaId == id);
    }
}
