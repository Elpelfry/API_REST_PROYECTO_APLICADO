using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    /// <inheritdoc />
    public partial class SecondConf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
