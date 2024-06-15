using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Roles
{
    [Key]
    public int RolId { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la descripción del rol.")]
    public string? RolName { get; set; }
}
