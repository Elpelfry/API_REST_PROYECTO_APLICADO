using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class Reservaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Reservaciones");

            migrationBuilder.RenameColumn(
                name: "TipoReservacioneId",
                table: "Reservaciones",
                newName: "InventarioReservaId");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Reservaciones",
                newName: "FechaRetorno");

            migrationBuilder.AddColumn<string>(
                name: "CodigoReservacion",
                table: "Reservaciones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEmision",
                table: "Reservaciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "InventarioReservas",
                columns: table => new
                {
                    InventarioReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FotoReserva = table.Column<byte[]>(type: "longblob", nullable: true),
                    ExtensionFoto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioReservas", x => x.InventarioReservaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleInventarioReservas",
                columns: table => new
                {
                    DetalleInventarioReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InventarioReservaId = table.Column<int>(type: "int", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaRetorno = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InventarioReservasInventarioReservaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleInventarioReservas", x => x.DetalleInventarioReservaId);
                    table.ForeignKey(
                        name: "FK_DetalleInventarioReservas_InventarioReservas_InventarioReser~",
                        column: x => x.InventarioReservasInventarioReservaId,
                        principalTable: "InventarioReservas",
                        principalColumn: "InventarioReservaId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInventarioReservas_InventarioReservasInventarioReserv~",
                table: "DetalleInventarioReservas",
                column: "InventarioReservasInventarioReservaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleInventarioReservas");

            migrationBuilder.DropTable(
                name: "InventarioReservas");

            migrationBuilder.DropColumn(
                name: "CodigoReservacion",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "FechaEmision",
                table: "Reservaciones");

            migrationBuilder.RenameColumn(
                name: "InventarioReservaId",
                table: "Reservaciones",
                newName: "TipoReservacioneId");

            migrationBuilder.RenameColumn(
                name: "FechaRetorno",
                table: "Reservaciones",
                newName: "Fecha");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Reservaciones",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
