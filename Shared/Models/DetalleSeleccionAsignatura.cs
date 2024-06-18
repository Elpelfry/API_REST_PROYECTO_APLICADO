using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleSeleccionAsignatura
{
    [Key]
    public int DetalleSeleccionAsignaturaId { get; set; }

    [ForeignKey("SeleccionAsignaturas")]
    public int SeleccionAsignaturaId { get; set; }

    [ForeignKey("Asignaturas")]
    public int AsignaturaId { get; set; }

    public int CantidadCreditos { get; set; }
}