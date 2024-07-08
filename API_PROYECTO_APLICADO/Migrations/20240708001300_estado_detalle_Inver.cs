using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class estado_detalle_Inver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleAsignaturas_Asignaturas_AsignaturasAsignaturaId",
                table: "DetalleAsignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleInventarioReservas_InventarioReservas_InventarioReser~",
                table: "DetalleInventarioReservas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleSeleccionAsignatura_SeleccionAsignaturas_SeleccionAsi~",
                table: "DetalleSeleccionAsignatura");

            migrationBuilder.DropIndex(
                name: "IX_DetalleSeleccionAsignatura_SeleccionAsignaturasSeleccionAsig~",
                table: "DetalleSeleccionAsignatura");

            migrationBuilder.DropIndex(
                name: "IX_DetalleInventarioReservas_InventarioReservasInventarioReserv~",
                table: "DetalleInventarioReservas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleAsignaturas_AsignaturasAsignaturaId",
                table: "DetalleAsignaturas");

            migrationBuilder.DropColumn(
                name: "SeleccionAsignaturasSeleccionAsignaturaId",
                table: "DetalleSeleccionAsignatura");

            migrationBuilder.DropColumn(
                name: "InventarioReservasInventarioReservaId",
                table: "DetalleInventarioReservas");

            migrationBuilder.DropColumn(
                name: "AsignaturasAsignaturaId",
                table: "DetalleAsignaturas");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "DetalleInventarioReservas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSeleccionAsignatura_SeleccionAsignaturaId",
                table: "DetalleSeleccionAsignatura",
                column: "SeleccionAsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInventarioReservas_InventarioReservaId",
                table: "DetalleInventarioReservas",
                column: "InventarioReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAsignaturas_AsignaturaId",
                table: "DetalleAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleAsignaturas_Asignaturas_AsignaturaId",
                table: "DetalleAsignaturas",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "AsignaturaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleInventarioReservas_InventarioReservas_InventarioReser~",
                table: "DetalleInventarioReservas",
                column: "InventarioReservaId",
                principalTable: "InventarioReservas",
                principalColumn: "InventarioReservaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleSeleccionAsignatura_SeleccionAsignaturas_SeleccionAsi~",
                table: "DetalleSeleccionAsignatura",
                column: "SeleccionAsignaturaId",
                principalTable: "SeleccionAsignaturas",
                principalColumn: "SeleccionAsignaturaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleAsignaturas_Asignaturas_AsignaturaId",
                table: "DetalleAsignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleInventarioReservas_InventarioReservas_InventarioReser~",
                table: "DetalleInventarioReservas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleSeleccionAsignatura_SeleccionAsignaturas_SeleccionAsi~",
                table: "DetalleSeleccionAsignatura");

            migrationBuilder.DropIndex(
                name: "IX_DetalleSeleccionAsignatura_SeleccionAsignaturaId",
                table: "DetalleSeleccionAsignatura");

            migrationBuilder.DropIndex(
                name: "IX_DetalleInventarioReservas_InventarioReservaId",
                table: "DetalleInventarioReservas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleAsignaturas_AsignaturaId",
                table: "DetalleAsignaturas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "DetalleInventarioReservas");

            migrationBuilder.AddColumn<int>(
                name: "SeleccionAsignaturasSeleccionAsignaturaId",
                table: "DetalleSeleccionAsignatura",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InventarioReservasInventarioReservaId",
                table: "DetalleInventarioReservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AsignaturasAsignaturaId",
                table: "DetalleAsignaturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSeleccionAsignatura_SeleccionAsignaturasSeleccionAsig~",
                table: "DetalleSeleccionAsignatura",
                column: "SeleccionAsignaturasSeleccionAsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInventarioReservas_InventarioReservasInventarioReserv~",
                table: "DetalleInventarioReservas",
                column: "InventarioReservasInventarioReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAsignaturas_AsignaturasAsignaturaId",
                table: "DetalleAsignaturas",
                column: "AsignaturasAsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleAsignaturas_Asignaturas_AsignaturasAsignaturaId",
                table: "DetalleAsignaturas",
                column: "AsignaturasAsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "AsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleInventarioReservas_InventarioReservas_InventarioReser~",
                table: "DetalleInventarioReservas",
                column: "InventarioReservasInventarioReservaId",
                principalTable: "InventarioReservas",
                principalColumn: "InventarioReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleSeleccionAsignatura_SeleccionAsignaturas_SeleccionAsi~",
                table: "DetalleSeleccionAsignatura",
                column: "SeleccionAsignaturasSeleccionAsignaturaId",
                principalTable: "SeleccionAsignaturas",
                principalColumn: "SeleccionAsignaturaId");
        }
    }
}
