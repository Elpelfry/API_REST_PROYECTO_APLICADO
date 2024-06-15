
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class SeleccionAsignaturas
{
    [Key]
    public int SeleccionAsignaturaId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [ForeignKey("Semestres")]
    public int SemestreId { get; set; }

    [Required(ErrorMessage ="Fecha de seleccion es requerido")]
    public DateTime FechaSeleccion { get; set; }

    public bool Estado { get; set; }

    [Required(ErrorMessage = "Cantidad de creditos permitidos es requerido")]
    [Range(1, 25, ErrorMessage = "Cantidad de creditos permitidos debe ser entre 1 y 25")]
    public int CantidadCreditosPermitidos { get; set; }

    [Required(ErrorMessage = "Cantidad de creditos seleccionados es requerido")]
    [Range(1, 25, ErrorMessage = "Cantidad de creditos permitidos debe ser entre 1 y 25")]
    public int CantidadCreditosSeleccionados { get; set; }

    [Required(ErrorMessage = "Cantidad de asignaturas es requerido")]
    public int CantidadAsignaturasSeleccionadas { get; set; }

    [ForeignKey("DetalleSeleccionAsignaturaId")]
    public ICollection<DetalleSeleccionAsignatura> DetalleSeleccionAsignaturas { get; set; } = new List<DetalleSeleccionAsignatura>();
}
