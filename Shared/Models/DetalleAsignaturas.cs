using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleAsignaturas
{
    [Key]
    public int DetalleAsignaturaId { get; set; }

    [ForeignKey("Asignaturas")]
    public int AsignaturaId { get; set; }

    [ForeignKey("Dias")]
    public int DiaId { get; set; }

    [Required(ErrorMessage = "El campo hora inicio es requerido")]
    public DateTime HoraInicio { get; set; }

    [Required(ErrorMessage = "El campo hora fin es requerido")]
    public DateTime HoraFin { get; set; }

    [Required(ErrorMessage = "El campo aula es requerido")]
    public string? Aula { get; set; }

    [Required(ErrorMessage = "El campo edificio es requerido")]
    public string? Edificio { get; set; }

    public string? Comentario { get; set; }
}