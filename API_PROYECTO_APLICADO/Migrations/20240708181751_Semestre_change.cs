using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class Semestre_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoInscripcion",
                table: "Semestres");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Semestres");

            migrationBuilder.DropColumn(
                name: "FechaFin",
                table: "Semestres");

            migrationBuilder.DropColumn(
                name: "CantidadCreditosPermitidos",
                table: "SeleccionAsignaturas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "SeleccionAsignaturas");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "Semestres",
                newName: "FechaCreacion");

            migrationBuilder.AlterColumn<byte[]>(
                name: "LogoEmpresa",
                table: "Configuraciones",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Configuraciones",
                keyColumn: "ConfiguracionId",
                keyValue: 1,
                column: "LogoEmpresa",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Semestres",
                newName: "FechaInicio");

            migrationBuilder.AddColumn<double>(
                name: "CargoInscripcion",
                table: "Semestres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Semestres",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFin",
                table: "Semestres",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CantidadCreditosPermitidos",
                table: "SeleccionAsignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "SeleccionAsignaturas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "LogoEmpresa",
                table: "Configuraciones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Configuraciones",
                keyColumn: "ConfiguracionId",
                keyValue: 1,
                column: "LogoEmpresa",
                value: null);
        }
    }
}
