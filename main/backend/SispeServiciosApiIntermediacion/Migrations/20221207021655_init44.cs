using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocalidadComuna",
                table: "VacanteUbicacion",
                newName: "LocalidadComunaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocalidadComunaId",
                table: "VacanteUbicacion",
                newName: "LocalidadComuna");
        }
    }
}
