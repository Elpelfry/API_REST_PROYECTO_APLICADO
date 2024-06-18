
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

    public DateTime FechaSeleccion { get; set; }

    public bool Estado { get; set; }

    public int CantidadCreditosPermitidos { get; set; }

    public int CantidadCreditosSeleccionados { get; set; }

    public int CantidadAsignaturasSeleccionadas { get; set; }

    public ICollection<DetalleSeleccionAsignatura> DetalleSeleccionAsignaturas { get; set; } = new List<DetalleSeleccionAsignatura>();
}
