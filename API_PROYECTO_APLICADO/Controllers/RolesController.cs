using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RolesController(Contexto _context) : ControllerBase
{
    // GET: api/Roles
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Roles>>> GetRoles()
    {
        return await _context.Roles.ToListAsync();
    }

    // GET: api/Roles/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Roles>> GetRoles(int id)
    {
        var roles = await _context.Roles.FindAsync(id);

        if (roles == null)
        {
            return NotFound();
        }

        return roles;
    }
}
