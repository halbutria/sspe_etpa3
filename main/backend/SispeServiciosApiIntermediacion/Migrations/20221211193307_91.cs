using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _91 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteOcupacionRelacionada_Vacante_VacanteId",
                table: "VacanteOcupacionRelacionada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteOcupacionRelacionada",
                table: "VacanteOcupacionRelacionada");

            migrationBuilder.RenameTable(
                name: "VacanteOcupacionRelacionada",
                newName: "VacanteDenominacionRelacionada");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteOcupacionRelacionada_VacanteId",
                table: "VacanteDenominacionRelacionada",
                newName: "IX_VacanteDenominacionRelacionada_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteDenominacionRelacionada",
                table: "VacanteDenominacionRelacionada",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteDenominacionRelacionada_Vacante_VacanteId",
                table: "VacanteDenominacionRelacionada",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteDenominacionRelacionada_Vacante_VacanteId",
                table: "VacanteDenominacionRelacionada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteDenominacionRelacionada",
                table: "VacanteDenominacionRelacionada");

            migrationBuilder.RenameTable(
                name: "VacanteDenominacionRelacionada",
                newName: "VacanteOcupacionRelacionada");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteDenominacionRelacionada_VacanteId",
                table: "VacanteOcupacionRelacionada",
                newName: "IX_VacanteOcupacionRelacionada_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteOcupacionRelacionada",
                table: "VacanteOcupacionRelacionada",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteOcupacionRelacionada_Vacante_VacanteId",
                table: "VacanteOcupacionRelacionada",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
