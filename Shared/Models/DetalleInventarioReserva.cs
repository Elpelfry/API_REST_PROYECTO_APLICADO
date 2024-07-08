using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleInventarioReserva
{
    [Key]
    public int DetalleInventarioReservaId { get; set; }

    [ForeignKey("InventarioReservas")]
    public int InventarioReservaId { get; set; }

    public DateTime FechaEmision { get; set; }
    
    public DateTime FechaRetorno { get; set; }

    public bool Estado { get; set; }
}
