using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class DetalleInventarioReserva
{
    [Key]
    public int DetalleInventarioReservaId { get; set; }

    public int InventarioReservaId { get; set; }

    public DateTime FechaEmision { get; set; }
    
    public DateTime FechaRetorno { get; set; }
}
