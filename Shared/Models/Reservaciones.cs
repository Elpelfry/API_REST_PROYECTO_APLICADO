using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Reservaciones
{
    [Key]
    public int ReservacionId { get; set; }

    public int InventarioReservaId { get; set; }
    public string? CodigoReservacion { get; set; }

    public int UsuarioId { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaRetorno { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }
}
