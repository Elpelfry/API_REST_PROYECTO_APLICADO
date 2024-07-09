using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleSemestrePlan
{
    [Key]
    public int DetalleSemestrePlanId { get; set; }

    [ForeignKey("SemestrePlan")]
    public int SemestrePlanId { get; set; }

    public string? Materia { get; set; }

    public int Creditos { get; set; }

    [ForeignKey("DetalleSemestrePlanId")]
    public ICollection<DetalleDetalleSemestrePlan> DetalleDetalleSemestrePlan { get; set; } = new List<DetalleDetalleSemestrePlan>();
}