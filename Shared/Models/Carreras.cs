using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Carreras
{
    [Key]
    public int CarreraId { get; set; }

    public string? Nombre { get; set; }
}
