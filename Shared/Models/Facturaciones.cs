using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Facturaciones
{
    [Key]
    public int FacturacionId { get; set; }


    public int SemestreId { get; set; }


    public int UsuarioId { get; set; }

    public DateTime? FechaEmision { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public double? Monto { get; set; }

    public bool Estado { get; set; }

    public string? Nota { get; set; }
}
