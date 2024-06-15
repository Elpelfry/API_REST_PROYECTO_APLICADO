using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Facturaciones
{
    [Key]
    public int FacturacionId { get; set; }

    [ForeignKey("Semestres")]
    public int SemestreId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de Emision")]
    public DateTime? FechaEmision { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de Vencimiento")]
    public DateTime? FechaVencimiento { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el monto")]
    public double? Monto { get; set; }

    public bool Estado { get; set; }

    public string? Nota { get; set; }
}
