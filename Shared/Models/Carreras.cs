using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Carreras
{
    [Key]
    public int CarreraId { get; set; }

    [Required(ErrorMessage ="nombre de carrera es obligatorio")]
    public string? Nombre { get; set; }
}
