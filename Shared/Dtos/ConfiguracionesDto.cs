
namespace Shared.Dtos;

public class ConfiguracionesDto
{
    public int ConfiguracionId { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? Rnc { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public float PrecioCredito { get; set; }

    public float PrecioAdmision { get; set; }

    public float PrecioInscripcion { get; set; }

    public float PorcentajeRegcargo { get; set; }

    public string? EstadoRetiro { get; set; }

    public string? EstadoInscripcion { get; set; }

    public string? EstadoAdmision { get; set; }

    public string? EstadoPublicacion { get; set; }

    public string? VozLectora { get; set; }

    public string? DominioEmpresa { get; set; }
    public string? URLCalendario { get; set; }
    public string? PeriodoCalendario { get; set; }

    public string? CorreoElectronico { get; set; }
}
