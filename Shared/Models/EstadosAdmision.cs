using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class EstadosAdmision
{
    [Key]
    public int EstadoAdmisionId { get; set; }

    public string? Descripcion { get; set; }
}
