using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class TiposReservaciones
{
    [Key]
    public int TipoReservacioneId { get; set; }

    [Required(ErrorMessage = "El campo descripcion es requerido")]
    public string? Descripcion { get; set; }
}
