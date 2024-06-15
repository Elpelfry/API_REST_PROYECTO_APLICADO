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

    [Required(ErrorMessage = "Es obligatorio introducir el o los nombres del usuario.")]
    public string? Nombres { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir apellidos del usuario.")]
    public string? Apellidos { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de nacimiento del estudiante.")]
    public DateTime? FechaNacimiento { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el correo electronico personal")]
    [EmailAddress(ErrorMessage = "El formato de correo electronico no es válido.")]
    public string? CorreoElectronicoPersonal { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el correo electronico institucional")]
    [EmailAddress(ErrorMessage = "El formato de correo electronico no es válido.")]
    public string? CorreoElectronicoInstitucional { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el numero de telefono")]
    [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "El formato de numero de telefono no es válido.")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el numero de telefono")]
    [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "El formato de numero de telefono no es válido.")]
    public string? TelefonoCasa { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el numero de Matricula")]
    [RegularExpression(@"\d{4}-\d{4}", ErrorMessage = "El formato de la matricula no es valido.")]
    public string? Matricula { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la direccion")]
    public string? Direccion { get; set; }

    [RegularExpression(@"\d{3}-\d{7}-\d{1}", ErrorMessage = "El formato de cedula no es válido.")]
    public string? Cedula { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el nombre de usuario")]
    public string? NombreUsuario { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la contraseña")]
    public string? Contrasena { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de ingreso")]
    public DateTime? FechaIngreso { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de egreso")]
    public DateTime? FechaEgreso { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la foto usuario")]
    public byte[]? FotoUsuario { get; set; }

}
