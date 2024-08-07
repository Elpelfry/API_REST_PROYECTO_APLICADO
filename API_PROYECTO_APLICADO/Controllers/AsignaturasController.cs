﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AsignaturasController(Contexto _context) : ControllerBase
{
    // GET: api/Asignaturas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Asignaturas>>> GetAsignaturas()
    {
        return Ok(await _context.Asignaturas.Include(a => a.DetalleAsignaturas).ToListAsync());
    }

    // GET: api/Asignaturas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Asignaturas>> GetAsignaturas(int id)
    {
        var asignaturas = await _context.Asignaturas.Include(a => a.DetalleAsignaturas)
            .FirstOrDefaultAsync(a => a.AsignaturaId == id);

        if (asignaturas == null)
        {
            return NotFound();
        }

        return Ok(asignaturas);
    }

    // POST: api/Asignaturas
    [HttpPost]
    public async Task<ActionResult<Asignaturas>> PostAsignaturas(Asignaturas asignaturas)
    {
        asignaturas.AsignaturaId = 0;
        _context.Asignaturas.Add(asignaturas);
        await _context.SaveChangesAsync();

        return Ok(CreatedAtAction("GetAsignaturas", new { id = asignaturas.AsignaturaId }, asignaturas));
    }

    // PUT: api/Asignaturas/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsignaturas(int id, Asignaturas asignaturas)
    {
        if (id != asignaturas.AsignaturaId)
        {
            return BadRequest();
        }

        await _context.DetalleAsignaturas.Where(t => t.AsignaturaId == id)
                    .ExecuteDeleteAsync();

        foreach (var item in asignaturas.DetalleAsignaturas)
        {
            item.DetalleAsignaturaId = 0;
            item.AsignaturaId = id;
            _context.DetalleAsignaturas.Add(item);
        }

        _context.Entry(asignaturas).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AsignaturasExists(id))
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


    // DELETE: api/Asignaturas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsignaturas(int id)
    {
        var asignaturas = await _context.Asignaturas.FindAsync(id);
        if (asignaturas == null)
        {
            return NotFound();
        }

        await _context.DetalleAsignaturas.Where(t => t.AsignaturaId == id)
                   .ExecuteDeleteAsync();

        _context.Asignaturas.Remove(asignaturas);
        await _context.SaveChangesAsync();

        return Ok(NoContent());
    }

    private bool AsignaturasExists(int id)
    {
        return _context.Asignaturas.Any(e => e.AsignaturaId == id);
    }
}
