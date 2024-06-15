using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Semestres
{
    [Key]
    public int SemestreId { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string? Nombre{ get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de Inicio")]
    public DateTime? FechaInicio { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de Fin")]
    public DateTime? FechaFin { get; set; }

    public bool Estado { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el cargo de inscripcion")]
    [Range(0.01, 2000000, ErrorMessage = "El cargo de inscripcion debe ser mayor a 0.01 y menor a 2000000")]
    public double CargoInscripcion { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de Seleccion")]
    public DateTime? FechaInicioSeleccion { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de Fin de Seleccion")]
    public DateTime? FechaFinSeleccion { get; set; }
}
