namespace Shared.Dtos;

public class UsuarioDto
{
    public int UsuarioId { get; set; }


    public int RolId { get; set; }


    public int CarreraId { get; set; }


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
}
