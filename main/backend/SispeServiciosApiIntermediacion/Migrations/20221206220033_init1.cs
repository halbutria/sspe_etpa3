using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RangoInicailId",
                table: "Vacante",
                newName: "RangoSalarialInicailId");

            migrationBuilder.RenameColumn(
                name: "RangoFinalId",
                table: "Vacante",
                newName: "RangoSalarialFinalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RangoSalarialInicailId",
                table: "Vacante",
                newName: "RangoInicailId");

            migrationBuilder.RenameColumn(
                name: "RangoSalarialFinalId",
                table: "Vacante",
                newName: "RangoFinalId");
        }
    }
}
