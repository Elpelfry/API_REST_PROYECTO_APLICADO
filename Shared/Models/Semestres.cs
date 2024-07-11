using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Semestres
{
    [Key]
    public int SemestreId { get; set; }

    public string? Nombre{ get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaInicioSeleccion { get; set; }

    public DateTime? FechaFinSeleccion { get; set; }

    public DateTime? FechaRetiro { get; set; }
}
