using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VacanteCambioEstado_VacanteId",
                table: "VacanteCambioEstado",
                column: "VacanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteCambioEstado_Vacante_VacanteId",
                table: "VacanteCambioEstado",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteCambioEstado_Vacante_VacanteId",
                table: "VacanteCambioEstado");

            migrationBuilder.DropIndex(
                name: "IX_VacanteCambioEstado_VacanteId",
                table: "VacanteCambioEstado");
        }
    }
}
