using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Usuarios
{
    [Key]
    public int UsuarioId { get; set; }

    [ForeignKey("Roles")]
    public int RolId { get; set; }

    [ForeignKey("Carrera")]
    public int CarreraId { get; set; }

    [ForeignKey("Admiciones")]
    public int AdmisionId { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? CorreoElectronicoPersonal { get; set; }

    public string? CorreoElectronicoInstitucional { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoCasa { get; set; }

    public string? Matricula { get; set; }

    public string? Direccion { get; set; }

    public string? Cedula { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Contrasena { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public byte[]? FotoUsuario { get; set; }

}
