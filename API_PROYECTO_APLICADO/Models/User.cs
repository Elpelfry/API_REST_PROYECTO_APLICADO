using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_APLICADO.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
}
