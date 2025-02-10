using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CondicionSaludId",
                table: "VacanteCondicionSaludMental",
                newName: "CondicionSaludMentalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CondicionSaludMentalId",
                table: "VacanteCondicionSaludMental",
                newName: "CondicionSaludId");
        }
    }
}
