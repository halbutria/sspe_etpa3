using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _108 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MunicipioID",
                table: "VacanteUbicacion",
                newName: "MunicipioId");

            migrationBuilder.RenameColumn(
                name: "DepartamentoID",
                table: "VacanteUbicacion",
                newName: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MunicipioId",
                table: "VacanteUbicacion",
                newName: "MunicipioID");

            migrationBuilder.RenameColumn(
                name: "DepartamentoId",
                table: "VacanteUbicacion",
                newName: "DepartamentoID");
        }
    }
}
