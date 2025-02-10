using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _129 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoProyecto",
                table: "Vacante",
                newName: "TipoProyectos");

            migrationBuilder.RenameColumn(
                name: "EsHidrocarburo",
                table: "Vacante",
                newName: "EsHidrocarburos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoProyectos",
                table: "Vacante",
                newName: "TipoProyecto");

            migrationBuilder.RenameColumn(
                name: "EsHidrocarburos",
                table: "Vacante",
                newName: "EsHidrocarburo");
        }
    }
}
