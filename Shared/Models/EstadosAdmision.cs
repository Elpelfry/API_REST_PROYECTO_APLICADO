using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class EstadosAdmision
{
    [Key]
    public int EstadoAdmisionId { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la descripción del estado de admicion.")]
    public string? Descripcion { get; set; }
}
