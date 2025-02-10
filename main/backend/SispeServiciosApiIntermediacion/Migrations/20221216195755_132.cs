using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _132 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GetionadaPorPrestadorAlterno",
                table: "Vacante",
                newName: "GestionadaPorPrestadorAlterno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GestionadaPorPrestadorAlterno",
                table: "Vacante",
                newName: "GetionadaPorPrestadorAlterno");
        }
    }
}
