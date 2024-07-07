using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleAsignaturas
{
    [Key]
    public int DetalleAsignaturaId { get; set; }

    [ForeignKey("Asignaturas")]
    public int AsignaturaId { get; set; }


    public int DiaId { get; set; }

    public DateTime HoraInicio { get; set; }

    public DateTime HoraFin { get; set; }

    public string? Aula { get; set; }

    public string? Edificio { get; set; }

    public string? Comentario { get; set; }
}