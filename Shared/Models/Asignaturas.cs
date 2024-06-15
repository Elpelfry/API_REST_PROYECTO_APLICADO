using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Asignaturas
{
    [Key]
    public int AsignaturaId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "El campo codigo materia es requerido")]
    public string? CodigoMateria { get; set; }

    [Required(ErrorMessage = "El campo nombre materia es requerido")]
    public string? NombreMateria { get; set; }

    [Required(ErrorMessage = "El campo creditos es requerido")]
    public int Creditos { get; set; }

    [Required(ErrorMessage = "El campo precio de credito es requerido")]
    public double PrecioCredito { get; set; }

    [Required(ErrorMessage = "El campo seccion es requerido")]
    public string? Seccion { get; set; }

    [Required(ErrorMessage = "El campo cantidad de estudiante es requerido")]
    [Range(1, 50, ErrorMessage = "La cantidad de estudiantes debe ser entre 1 y 50")]
    public int CantidadEstudiantes { get; set; }

    public bool EsLaboratorio { get; set; }

    [ForeignKey("DetalleAsignaturaId")]
    public ICollection<DetalleAsignaturas> DetalleAsignaturas { get; set; } = new List<DetalleAsignaturas>();
}
