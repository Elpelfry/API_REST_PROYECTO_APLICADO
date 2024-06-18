using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Roles
{
    [Key]
    public int RolId { get; set; }

    public string? RolName { get; set; }
}
