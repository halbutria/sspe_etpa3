using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacantesMotivosExepcionalidad_Vacante_VacanteId",
                table: "VacantesMotivosExepcionalidad");

            migrationBuilder.DropForeignKey(
                name: "FK_VacantesUbicaciones_Vacante_VacanteId",
                table: "VacantesUbicaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacantesUbicaciones",
                table: "VacantesUbicaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacantesMotivosExepcionalidad",
                table: "VacantesMotivosExepcionalidad");

            migrationBuilder.RenameTable(
                name: "VacantesUbicaciones",
                newName: "VacanteUbicacion");

            migrationBuilder.RenameTable(
                name: "VacantesMotivosExepcionalidad",
                newName: "VacanteMotivosExepcionalidad");

            migrationBuilder.RenameIndex(
                name: "IX_VacantesUbicaciones_VacanteId",
                table: "VacanteUbicacion",
                newName: "IX_VacanteUbicacion_VacanteId");

            migrationBuilder.RenameIndex(
                name: "IX_VacantesMotivosExepcionalidad_VacanteId",
                table: "VacanteMotivosExepcionalidad",
                newName: "IX_VacanteMotivosExepcionalidad_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteUbicacion",
                table: "VacanteUbicacion",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteUbicacion_Vacante_VacanteId",
                table: "VacanteUbicacion",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteMotivosExepcionalidad_Vacante_VacanteId",
                table: "VacanteMotivosExepcionalidad");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteUbicacion_Vacante_VacanteId",
                table: "VacanteUbicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteUbicacion",
                table: "VacanteUbicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteMotivosExepcionalidad",
                table: "VacanteMotivosExepcionalidad");

            migrationBuilder.RenameTable(
                name: "VacanteUbicacion",
                newName: "VacantesUbicaciones");

            migrationBuilder.RenameTable(
                name: "VacanteMotivosExepcionalidad",
                newName: "VacantesMotivosExepcionalidad");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteUbicacion_VacanteId",
                table: "VacantesUbicaciones",
                newName: "IX_VacantesUbicaciones_VacanteId");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteMotivosExepcionalidad_VacanteId",
                table: "VacantesMotivosExepcionalidad",
                newName: "IX_VacantesMotivosExepcionalidad_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacantesUbicaciones",
                table: "VacantesUbicaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacantesMotivosExepcionalidad",
                table: "VacantesMotivosExepcionalidad",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacantesMotivosExepcionalidad_Vacante_VacanteId",
                table: "VacantesMotivosExepcionalidad",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacantesUbicaciones_Vacante_VacanteId",
                table: "VacantesUbicaciones",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
