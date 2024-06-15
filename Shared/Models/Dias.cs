using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Dias
{
    [Key]
    public int DiaId { get; set; }

    [Required(ErrorMessage = "El campo dia es requerido")]
    public string? NombreDia { get; set; }
}
