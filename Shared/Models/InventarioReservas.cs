using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class InventarioReservas
{
    [Key]
    public int InventarioReservaId { get; set; }

    public string? Descripcion { get; set; }

    public int Cantidad { get; set; }

    public bool Estado { get; set; }

    public byte[]? FotoReserva { get; set; }

    public string? ExtensionFoto{ get; set; }

    [ForeignKey("InventarioReservaId")]
    public ICollection<DetalleInventarioReserva> InventarioReservacionesDetalle { get; set; } = new List<DetalleInventarioReserva>();
}
