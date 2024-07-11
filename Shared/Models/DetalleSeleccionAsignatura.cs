using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleSeleccionAsignatura
{
    [Key]
    public int DetalleSeleccionAsignaturaId { get; set; }

    [ForeignKey("SeleccionAsignaturas")]
    public int SeleccionAsignaturaId { get; set; }

    public int DetalleDetalleSemestrePlanId { get; set; }

    public float Calificacion { get; set; }

    public int Creditos { get; set; }

    public string? Estado { get; set; }
}