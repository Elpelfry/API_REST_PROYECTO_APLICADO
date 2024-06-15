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

    [Required(ErrorMessage = "Valor de calificacion es requerido")]
    [Range(0, 100, ErrorMessage = "Valor de calificacion debe estar entre 0 y 100")]
    public int CantidadCreditos { get; set; }
}