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

    [Required(ErrorMessage = "El campo fecha es requerido")]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "El campo descripcion es requerido")]
    public string? Descripcion { get; set; }

    public bool Estado { get; set; }
}
