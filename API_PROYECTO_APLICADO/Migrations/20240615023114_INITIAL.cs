using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admisiones",
                columns: table => new
                {
                    AdmisioneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LugarNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoCasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    RecordNotas = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ActaNacimiento = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CertificadoMedico = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CertificadoBachiller = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Fotografia = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Tarjetavacunacion = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoAdmicionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admisiones", x => x.AdmisioneId);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CodigoMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creditos = table.Column<int>(type: "int", nullable: false),
                    PrecioCredito = table.Column<double>(type: "float", nullable: false),
                    Seccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadEstudiantes = table.Column<int>(type: "int", nullable: false),
                    EsLaboratorio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.CarreraId);
                });

            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    DiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dias", x => x.DiaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosAdmision",
                columns: table => new
                {
                    EstadoAdmisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosAdmision", x => x.EstadoAdmisionId);
                });

            migrationBuilder.CreateTable(
                name: "Facturaciones",
                columns: table => new
                {
                    FacturacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemestreId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturaciones", x => x.FacturacionId);
                });

            migrationBuilder.CreateTable(
                name: "Reservaciones",
                columns: table => new
                {
                    ReservacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoReservacioneId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservaciones", x => x.ReservacionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "SeleccionAsignaturas",
                columns: table => new
                {
                    SeleccionAsignaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    SemestreId = table.Column<int>(type: "int", nullable: false),
                    FechaSeleccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CantidadCreditosPermitidos = table.Column<int>(type: "int", nullable: false),
                    CantidadCreditosSeleccionados = table.Column<int>(type: "int", nullable: false),
                    CantidadAsignaturasSeleccionadas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeleccionAsignaturas", x => x.SeleccionAsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Semestres",
                columns: table => new
                {
                    SemestreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CargoInscripcion = table.Column<double>(type: "float", nullable: false),
                    FechaInicioSeleccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinSeleccion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestres", x => x.SemestreId);
                });

            migrationBuilder.CreateTable(
                name: "TiposReservaciones",
                columns: table => new
                {
                    TipoReservacioneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposReservaciones", x => x.TipoReservacioneId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    AdmisionId = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoElectronicoPersonal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronicoInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoCasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoUsuario = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "DetalleAsignaturas",
                columns: table => new
                {
                    DetalleAsignaturaId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    DiaId = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edificio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleAsignaturas", x => x.DetalleAsignaturaId);
                    table.ForeignKey(
                        name: "FK_DetalleAsignaturas_Asignaturas_DetalleAsignaturaId",
                        column: x => x.DetalleAsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "AsignaturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleSeleccionAsignatura",
                columns: table => new
                {
                    DetalleSeleccionAsignaturaId = table.Column<int>(type: "int", nullable: false),
                    SeleccionAsignaturaId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    CantidadCreditos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleSeleccionAsignatura", x => x.DetalleSeleccionAsignaturaId);
                    table.ForeignKey(
                        name: "FK_DetalleSeleccionAsignatura_SeleccionAsignaturas_DetalleSeleccionAsignaturaId",
                        column: x => x.DetalleSeleccionAsignaturaId,
                        principalTable: "SeleccionAsignaturas",
                        principalColumn: "SeleccionAsignaturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "DiaId", "NombreDia" },
                values: new object[,]
                {
                    { 1, "Lunes" },
                    { 2, "Martes" },
                    { 3, "Miercoles" },
                    { 4, "Jueves" },
                    { 5, "Viernes" },
                    { 6, "Sabado" },
                    { 7, "Domingo" }
                });

            migrationBuilder.InsertData(
                table: "EstadosAdmision",
                columns: new[] { "EstadoAdmisionId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Pendiente" },
                    { 2, "Aceptado" },
                    { 3, "Rechazado" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "RolName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Estudiante" },
                    { 3, "Profesor" },
                    { 4, "Admisor" }
                });

            migrationBuilder.InsertData(
                table: "TiposReservaciones",
                columns: new[] { "TipoReservacioneId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Laboratorio" },
                    { 2, "Proyector" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admisiones");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "DetalleAsignaturas");

            migrationBuilder.DropTable(
                name: "DetalleSeleccionAsignatura");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropTable(
                name: "EstadosAdmision");

            migrationBuilder.DropTable(
                name: "Facturaciones");

            migrationBuilder.DropTable(
                name: "Reservaciones");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Semestres");

            migrationBuilder.DropTable(
                name: "TiposReservaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "SeleccionAsignaturas");
        }
    }
}
