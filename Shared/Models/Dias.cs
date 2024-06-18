using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Dias
{
    [Key]
    public int DiaId { get; set; }

    public string? NombreDia { get; set; }
}
