using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class SemestrePlan
{
    [Key]
    public int SemestrePlanId { get; set; }

    public int CarreraId { get; set; }

    public string? Descripcion { get; set; }

    [ForeignKey("SemestrePlanId")]
    public ICollection<DetalleSemestrePlan> DetalleSemestrePlan { get; set; } = new List<DetalleSemestrePlan>();
}
