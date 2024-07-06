using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoExtension",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ActaNacimientoExtension",
                table: "Admisiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CertificadoBachillerExtension",
                table: "Admisiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CertificadoMedicoExtension",
                table: "Admisiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FotoExtension",
                table: "Admisiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RecordNotasExtension",
                table: "Admisiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TarjetavacunacionExtension",
                table: "Admisiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoExtension",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ActaNacimientoExtension",
                table: "Admisiones");

            migrationBuilder.DropColumn(
                name: "CertificadoBachillerExtension",
                table: "Admisiones");

            migrationBuilder.DropColumn(
                name: "CertificadoMedicoExtension",
                table: "Admisiones");

            migrationBuilder.DropColumn(
                name: "FotoExtension",
                table: "Admisiones");

            migrationBuilder.DropColumn(
                name: "RecordNotasExtension",
                table: "Admisiones");

            migrationBuilder.DropColumn(
                name: "TarjetavacunacionExtension",
                table: "Admisiones");
        }
    }
}
