using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Asignaturas
{
    [Key]
    public int AsignaturaId { get; set; }


    public int UsuarioId { get; set; }

    public string? CodigoMateria { get; set; }

    public string? NombreMateria { get; set; }

    public int Creditos { get; set; }

    public double PrecioCredito { get; set; }

    public string? Seccion { get; set; }

    public int CantidadEstudiantes { get; set; }

    public bool EsLaboratorio { get; set; }

    [ForeignKey("AsignaturaId")]
    public ICollection<DetalleAsignaturas> DetalleAsignaturas { get; set; } = new List<DetalleAsignaturas>();
}
