using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class seleccionupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadAsignaturasSeleccionadas",
                table: "SeleccionAsignaturas");

            migrationBuilder.DropColumn(
                name: "CantidadCreditosSeleccionados",
                table: "SeleccionAsignaturas");

            migrationBuilder.RenameColumn(
                name: "CantidadCreditos",
                table: "DetalleSeleccionAsignatura",
                newName: "DetalleDetalleSemestrePlanId");

            migrationBuilder.RenameColumn(
                name: "AsignaturaId",
                table: "DetalleSeleccionAsignatura",
                newName: "Creditos");

            migrationBuilder.AddColumn<float>(
                name: "Calificacion",
                table: "DetalleSeleccionAsignatura",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calificacion",
                table: "DetalleSeleccionAsignatura");

            migrationBuilder.RenameColumn(
                name: "DetalleDetalleSemestrePlanId",
                table: "DetalleSeleccionAsignatura",
                newName: "CantidadCreditos");

            migrationBuilder.RenameColumn(
                name: "Creditos",
                table: "DetalleSeleccionAsignatura",
                newName: "AsignaturaId");

            migrationBuilder.AddColumn<int>(
                name: "CantidadAsignaturasSeleccionadas",
                table: "SeleccionAsignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadCreditosSeleccionados",
                table: "SeleccionAsignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
