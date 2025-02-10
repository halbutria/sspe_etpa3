using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _96 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RangoSalarialInicail",
                table: "Vacante",
                newName: "RangoSalarialInicial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RangoSalarialInicial",
                table: "Vacante",
                newName: "RangoSalarialInicail");
        }
    }
}
