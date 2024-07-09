using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleDetalleSemestrePlan
{
    [Key]
    public int DetalleDetalleSemestrePlanId { get; set; }

    [ForeignKey("DetalleSemestrePlan")]
    public int DetalleSemestrePlanId { get; set; }

    public int UsuarioId { get; set; }

    public string? Aula { get; set; }

    public string? Grupo { get; set; }

    public int DiaId { get; set; }
    public string? HoraInicio { get; set; }
    public string? HoraFin { get; set; }
}
