using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _107 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DenominacionRelacionadoId",
                table: "VacanteDenominacionRelacionada",
                newName: "DenominacionRelacionadaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DenominacionRelacionadaId",
                table: "VacanteDenominacionRelacionada",
                newName: "DenominacionRelacionadoId");
        }
    }
}
