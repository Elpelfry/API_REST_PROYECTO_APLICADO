using System.ComponentModel.DataAnnotations;

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

    public ICollection<DetalleInventarioReserva> InventarioReservacionesDetalle { get; set; } = new List<DetalleInventarioReserva>();
}
