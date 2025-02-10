using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _113 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lectura",
                table: "VacanteIdioma",
                newName: "NivelLecturaId");

            migrationBuilder.RenameColumn(
                name: "Escucha",
                table: "VacanteIdioma",
                newName: "NivelEscuchaId");

            migrationBuilder.RenameColumn(
                name: "Escritura",
                table: "VacanteIdioma",
                newName: "NivelEscrituraId");

            migrationBuilder.RenameColumn(
                name: "Conversacional",
                table: "VacanteIdioma",
                newName: "NivelConversacionalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NivelLecturaId",
                table: "VacanteIdioma",
                newName: "Lectura");

            migrationBuilder.RenameColumn(
                name: "NivelEscuchaId",
                table: "VacanteIdioma",
                newName: "Escucha");

            migrationBuilder.RenameColumn(
                name: "NivelEscrituraId",
                table: "VacanteIdioma",
                newName: "Escritura");

            migrationBuilder.RenameColumn(
                name: "NivelConversacionalId",
                table: "VacanteIdioma",
                newName: "Conversacional");
        }
    }
}
