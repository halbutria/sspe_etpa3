using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _93 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Indicador",
                table: "Vacante",
                newName: "Identificador");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Vacante",
                newName: "SedeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SedeId",
                table: "Vacante",
                newName: "EmpresaId");

            migrationBuilder.RenameColumn(
                name: "Identificador",
                table: "Vacante",
                newName: "Indicador");
        }
    }
}
