using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class DetalleSeleccionAsignatura
{
    [Key]
    public int DetalleSeleccionAsignaturaId { get; set; }


    public int SeleccionAsignaturaId { get; set; }


    public int AsignaturaId { get; set; }

    public int CantidadCreditos { get; set; }
}