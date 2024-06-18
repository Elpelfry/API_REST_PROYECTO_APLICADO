using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class TiposReservaciones
{
    [Key]
    public int TipoReservacioneId { get; set; }

    public string? Descripcion { get; set; }
}
