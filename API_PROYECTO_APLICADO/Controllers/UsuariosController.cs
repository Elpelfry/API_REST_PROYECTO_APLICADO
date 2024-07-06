using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;
using Shared.Dtos;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController(Contexto _context) : ControllerBase
{
    // GET: api/Usuarios
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Usuarios>>> GetUsuarios()
    {
        return Ok(await _context.Usuarios.ToListAsync());
    }

    // GET: api/Usuarios/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Usuarios>> GetUsuarios(int id)
    {
        var usuarios = await _context.Usuarios.FindAsync(id);

        if (usuarios == null)
        {
            return NotFound();
        }

        return Ok(usuarios);
    }

    // GET: api/Usuarios/UserbyidLite/5
    [HttpGet("UserbyidLite/{id}")]
    public async Task<ActionResult<UsuarioDto>> GetUsuariosWhithoutImage(int id)
    {
        var usuarios = await _context.Usuarios.Select(u => new UsuarioDto
        {
            UsuarioId = u.UsuarioId,
            RolId = u.RolId,
            CarreraId = u.CarreraId,
            AdmisionId = u.AdmisionId,
            Nombres = u.Nombres,
            Apellidos = u.Apellidos,
            FechaNacimiento = u.FechaNacimiento,
            CorreoElectronicoPersonal = u.CorreoElectronicoPersonal,
            CorreoElectronicoInstitucional = u.CorreoElectronicoInstitucional,
            Telefono = u.Telefono,
            TelefonoCasa = u.TelefonoCasa,
            Matricula = u.Matricula,
            Direccion = u.Direccion,
            Cedula = u.Cedula,
            NombreUsuario = u.NombreUsuario,
            Contrasena = u.Contrasena,
            FechaIngreso = u.FechaIngreso,
            FechaEgreso = u.FechaEgreso
        }).FirstOrDefaultAsync(u => u.UsuarioId == id);

        if (usuarios == null)
        {
            return NotFound();
        }

        return Ok(usuarios);
    }

    // POST: api/Usuarios
    [HttpPost]
    public async Task<ActionResult<Usuarios>> PostUsuarios(Usuarios usuarios)
    {
        _context.Usuarios.Add(usuarios);
        await _context.SaveChangesAsync();

        return Ok(CreatedAtAction("GetUsuarios", new { id = usuarios.UsuarioId }, usuarios));
    }

    // PUT: api/Usuarios/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUsuarios(int id, Usuarios usuarios)
    {
        if (id != usuarios.UsuarioId)
        {
            return BadRequest();
        }

        _context.Entry(usuarios).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UsuariosExists(id))
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

    // DELETE: api/Usuarios/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUsuarios(int id)
    {
        var usuarios = await _context.Usuarios.FindAsync(id);
        if (usuarios == null)
        {
            return NotFound();
        }

        _context.Usuarios.Remove(usuarios);
        await _context.SaveChangesAsync();

        return Ok(NoContent());
    }

    private bool UsuariosExists(int id)
    {
        return _context.Usuarios.Any(e => e.UsuarioId == id);
    }
}
