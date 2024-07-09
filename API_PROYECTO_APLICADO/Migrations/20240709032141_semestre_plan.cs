using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class semestre_plan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SemestrePlan",
                columns: table => new
                {
                    SemestrePlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemestrePlan", x => x.SemestrePlanId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleSemestrePlan",
                columns: table => new
                {
                    DetalleSemestrePlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SemestrePlanId = table.Column<int>(type: "int", nullable: false),
                    Materia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Creditos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleSemestrePlan", x => x.DetalleSemestrePlanId);
                    table.ForeignKey(
                        name: "FK_DetalleSemestrePlan_SemestrePlan_SemestrePlanId",
                        column: x => x.SemestrePlanId,
                        principalTable: "SemestrePlan",
                        principalColumn: "SemestrePlanId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleDetalleSemestrePlan",
                columns: table => new
                {
                    DetalleDetalleSemestrePlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DetalleSemestrePlanId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Aula = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Grupo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiaId = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraFin = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleDetalleSemestrePlan", x => x.DetalleDetalleSemestrePlanId);
                    table.ForeignKey(
                        name: "FK_DetalleDetalleSemestrePlan_DetalleSemestrePlan_DetalleSemest~",
                        column: x => x.DetalleSemestrePlanId,
                        principalTable: "DetalleSemestrePlan",
                        principalColumn: "DetalleSemestrePlanId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDetalleSemestrePlan_DetalleSemestrePlanId",
                table: "DetalleDetalleSemestrePlan",
                column: "DetalleSemestrePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSemestrePlan_SemestrePlanId",
                table: "DetalleSemestrePlan",
                column: "SemestrePlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleDetalleSemestrePlan");

            migrationBuilder.DropTable(
                name: "DetalleSemestrePlan");

            migrationBuilder.DropTable(
                name: "SemestrePlan");
        }
    }
}
