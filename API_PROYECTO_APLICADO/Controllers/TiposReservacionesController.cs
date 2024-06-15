using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TiposReservacionesController(Contexto _context) : ControllerBase
{
    // GET: api/TiposReservaciones
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TiposReservaciones>>> GetTiposReservaciones()
    {
        return await _context.TiposReservaciones.ToListAsync();
    }

    // GET: api/TiposReservaciones/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TiposReservaciones>> GetTiposReservaciones(int id)
    {
        var tiposReservaciones = await _context.TiposReservaciones.FindAsync(id);

        if (tiposReservaciones == null)
        {
            return NotFound();
        }

        return tiposReservaciones;
    }
}
