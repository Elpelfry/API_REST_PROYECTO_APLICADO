using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Semestres
{
    [Key]
    public int SemestreId { get; set; }

    public string? Nombre{ get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool Estado { get; set; }

    public double CargoInscripcion { get; set; }

    public DateTime? FechaInicioSeleccion { get; set; }

    public DateTime? FechaFinSeleccion { get; set; }
}
