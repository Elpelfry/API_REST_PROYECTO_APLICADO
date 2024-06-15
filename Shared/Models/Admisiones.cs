
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Admisiones
{
    [Key]
    public int AdmisioneId { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el nombre del estudiante.")]
    public string? Nombres { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el primer apellido del estudiante.")]
    public string? PrimerApellido { get; set; }
    [Required(ErrorMessage = "Es obligatorio introducir el segundo apellido del estudiante.")]
    public string? SegundoApellido { get; set; }

    [RegularExpression(@"\d{3}-\d{7}-\d{1}", ErrorMessage = "El formato de cedula no es válido.")]
    public string? Cedula { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la fecha de nacimiento del estudiante.")]
    public DateTime? FechaNacimiento { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el lugar de nacimiento del estudiante.")]
    public string? LugarNacimiento { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la ciudad de nacimiento")]
    public string? CiudadNacimiento { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el numero de telefono")]
    [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "El formato de numero de telefono no es válido.")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el numero de telefono")]
    [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "El formato de numero de telefono no es válido.")]
    public string? TelefonoCasa { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el correo electronico")]
    [EmailAddress(ErrorMessage = "El formato de correo electronico no es válido.")]
    public string? CorreoElectronico { get; set; }

    [ForeignKey("Carrera")]
    public int CarreraId { get; set; }

    [Required(ErrorMessage = "Es obligatorio anexar Record de notas")]
    public byte[]? RecordNotas { get; set; }

    [Required(ErrorMessage = "Es obligatorio anexar acta de nacimiento")]
    public byte[]? ActaNacimiento { get; set; }

    [Required(ErrorMessage = "Es obligatorio anexar certificaddo medico")]
    public byte[]? CertificadoMedico { get; set; }

    [Required(ErrorMessage = "Es obligatorio anexar certificado de bachiller")]
    public byte[]? CertificadoBachiller { get; set; }

    [Required(ErrorMessage = "Es obligatorio anexar fotografia 2x2")]
    public byte[]? Fotografia { get; set; }

    public byte[]? Tarjetavacunacion { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la direccion")]
    public string? Direccion { get; set; }

    [ForeignKey("EstadosAdmicion")]
    public int EstadoAdmicionId { get; set; }
}
