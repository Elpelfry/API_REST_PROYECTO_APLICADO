using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Reservaciones
{
    [Key]
    public int ReservacionId { get; set; }

    [ForeignKey("TiposReservaciones")]
    public int TipoReservacioneId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    public DateTime Fecha { get; set; }

    public string? Descripcion { get; set; }

    public bool Estado { get; set; }
}
