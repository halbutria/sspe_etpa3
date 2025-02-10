using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init46 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteMotivosExepcionalidad_Vacante_VacanteId",
                table: "VacanteMotivosExepcionalidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteMotivosExepcionalidad",
                table: "VacanteMotivosExepcionalidad");

            migrationBuilder.RenameTable(
                name: "VacanteMotivosExepcionalidad",
                newName: "VacanteMotivoExepcionalidad");

            migrationBuilder.RenameColumn(
                name: "NumeroPuesto",
                table: "VacanteUbicacion",
                newName: "NumeroPuestos");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteMotivosExepcionalidad_VacanteId",
                table: "VacanteMotivoExepcionalidad",
                newName: "IX_VacanteMotivoExepcionalidad_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteMotivoExepcionalidad",
                table: "VacanteMotivoExepcionalidad",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteMotivoExepcionalidad_Vacante_VacanteId",
                table: "VacanteMotivoExepcionalidad",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteMotivoExepcionalidad_Vacante_VacanteId",
                table: "VacanteMotivoExepcionalidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteMotivoExepcionalidad",
                table: "VacanteMotivoExepcionalidad");

            migrationBuilder.RenameTable(
                name: "VacanteMotivoExepcionalidad",
                newName: "VacanteMotivosExepcionalidad");

            migrationBuilder.RenameColumn(
                name: "NumeroPuestos",
                table: "VacanteUbicacion",
                newName: "NumeroPuesto");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteMotivoExepcionalidad_VacanteId",
                table: "VacanteMotivosExepcionalidad",
                newName: "IX_VacanteMotivosExepcionalidad_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteMotivosExepcionalidad",
                table: "VacanteMotivosExepcionalidad",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteMotivosExepcionalidad_Vacante_VacanteId",
                table: "VacanteMotivosExepcionalidad",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
