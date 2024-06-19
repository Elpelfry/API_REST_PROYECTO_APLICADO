using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiasController(Contexto _context) : ControllerBase
{
    // GET: api/Dias
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dias>>> GetDias()
    {
        return Ok(await _context.Dias.ToListAsync());
    }

    // GET: api/Dias/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Dias>> GetDias(int id)
    {
        var dias = await _context.Dias.FindAsync(id);

        if (dias == null)
        {
            return NotFound();
        }

        return Ok(dias);
    }
}
