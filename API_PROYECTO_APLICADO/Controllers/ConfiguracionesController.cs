using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_APLICADO.DAL;
using Shared.Models;
using Shared.Dtos;

namespace API_PROYECTO_APLICADO.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConfiguracionesController(Contexto _context) : ControllerBase
{
    // GET: api/Configuraciones
    [HttpGet]
    public async Task<ActionResult<Configuraciones>> GetConfiguraciones()
    {
        return Ok(await _context.Configuraciones.FirstOrDefaultAsync());
    }

    // GET: api/Configuraciones/5
    [HttpGet("Lite")]
    public async Task<ActionResult<ConfiguracionesDto>> GetConfiguracionesLite()
    {
        var configuraciones = await _context.Configuraciones.Select(p => new ConfiguracionesDto
        {
            ConfiguracionId = p.ConfiguracionId,
            NombreEmpresa = p.NombreEmpresa,
            Rnc = p.Rnc,
            Direccion = p.Direccion,
            Telefono = p.Telefono,
            PrecioCredito = p.PrecioCredito,
            PrecioAdmision = p.PrecioAdmision,
            PrecioInscripcion = p.PrecioInscripcion,
            PorcentajeRegcargo = p.PorcentajeRegcargo,
            EstadoRetiro = p.EstadoRetiro,
            EstadoInscripcion = p.EstadoInscripcion,
            EstadoAdmision = p.EstadoAdmision,
            EstadoPublicacion = p.EstadoPublicacion,
            VozLectora = p.VozLectora,
            DominioEmpresa = p.DominioEmpresa,
            URLCalendario = p.URLCalendario,
            PeriodoCalendario = p.PeriodoCalendario,
            CorreoElectronico = p.CorreoElectronico
        }).FirstOrDefaultAsync();

        if (configuraciones == null)
        {
            return NotFound();
        }

        return Ok(configuraciones);
    }

    // PUT: api/Configuraciones/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutConfiguraciones(int id, Configuraciones configuraciones)
    {
        if (id != configuraciones.ConfiguracionId)
        {
            return BadRequest();
        }

        _context.Entry(configuraciones).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ConfiguracionesExists(id))
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

    private bool ConfiguracionesExists(int id)
    {
        return _context.Configuraciones.Any(e => e.ConfiguracionId == id);
    }
}
