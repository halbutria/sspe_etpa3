using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CondicionSaludMental_Vacante_VacanteId",
                table: "CondicionSaludMental");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CondicionSaludMental",
                table: "CondicionSaludMental");

            migrationBuilder.RenameTable(
                name: "CondicionSaludMental",
                newName: "VacanteCondicionSaludMental");

            migrationBuilder.RenameIndex(
                name: "IX_CondicionSaludMental_VacanteId",
                table: "VacanteCondicionSaludMental",
                newName: "IX_VacanteCondicionSaludMental_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteCondicionSaludMental",
                table: "VacanteCondicionSaludMental",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteCondicionSaludMental_Vacante_VacanteId",
                table: "VacanteCondicionSaludMental",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteCondicionSaludMental_Vacante_VacanteId",
                table: "VacanteCondicionSaludMental");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteCondicionSaludMental",
                table: "VacanteCondicionSaludMental");

            migrationBuilder.RenameTable(
                name: "VacanteCondicionSaludMental",
                newName: "CondicionSaludMental");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteCondicionSaludMental_VacanteId",
                table: "CondicionSaludMental",
                newName: "IX_CondicionSaludMental_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CondicionSaludMental",
                table: "CondicionSaludMental",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CondicionSaludMental_Vacante_VacanteId",
                table: "CondicionSaludMental",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
