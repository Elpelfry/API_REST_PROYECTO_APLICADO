using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Dtos;

public class DetalleSeleccionAsignaturaDto
{
    public float Calificacion { get; set; }

    public string? Estado { get; set; }
}
