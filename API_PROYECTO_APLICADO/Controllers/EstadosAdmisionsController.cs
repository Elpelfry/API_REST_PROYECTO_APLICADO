using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EstadosAdmisionsController(Contexto _context) : ControllerBase
{
    // GET: api/EstadosAdmisions
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EstadosAdmision>>> GetEstadosAdmicion()
    {
        return await _context.EstadosAdmision.ToListAsync();
    }

    // GET: api/EstadosAdmisions/5
    [HttpGet("{id}")]
    public async Task<ActionResult<EstadosAdmision>> GetEstadosAdmision(int id)
    {
        var estadosAdmision = await _context.EstadosAdmision.FindAsync(id);

        if (estadosAdmision == null)
        {
            return NotFound();
        }

        return estadosAdmision;
    }
}
