using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _95 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RangoSalarialInicailId",
                table: "Vacante",
                newName: "RangoSalarialInicail");

            migrationBuilder.RenameColumn(
                name: "RangoSalarialFinalId",
                table: "Vacante",
                newName: "RangoSalarialFinal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RangoSalarialInicail",
                table: "Vacante",
                newName: "RangoSalarialInicailId");

            migrationBuilder.RenameColumn(
                name: "RangoSalarialFinal",
                table: "Vacante",
                newName: "RangoSalarialFinalId");
        }
    }
}
