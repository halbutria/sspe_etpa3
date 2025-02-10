using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteConocimientosCompetencias_Vacante_VacanteId",
                table: "VacanteConocimientosCompetencias");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteDiscapacidades_Vacante_VacanteId",
                table: "VacanteDiscapacidades");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteHabilidadesdDestrezas_Vacante_VacanteId",
                table: "VacanteHabilidadesdDestrezas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteHabilidadesdDestrezas",
                table: "VacanteHabilidadesdDestrezas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteDiscapacidades",
                table: "VacanteDiscapacidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteConocimientosCompetencias",
                table: "VacanteConocimientosCompetencias");

            migrationBuilder.RenameTable(
                name: "VacanteHabilidadesdDestrezas",
                newName: "VacanteHabilidadesdDestreza");

            migrationBuilder.RenameTable(
                name: "VacanteDiscapacidades",
                newName: "VacanteDiscapacidad");

            migrationBuilder.RenameTable(
                name: "VacanteConocimientosCompetencias",
                newName: "VacanteConocimientosCompetencia");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteHabilidadesdDestrezas_VacanteId",
                table: "VacanteHabilidadesdDestreza",
                newName: "IX_VacanteHabilidadesdDestreza_VacanteId");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteDiscapacidades_VacanteId",
                table: "VacanteDiscapacidad",
                newName: "IX_VacanteDiscapacidad_VacanteId");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteConocimientosCompetencias_VacanteId",
                table: "VacanteConocimientosCompetencia",
                newName: "IX_VacanteConocimientosCompetencia_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteHabilidadesdDestreza",
                table: "VacanteHabilidadesdDestreza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteDiscapacidad",
                table: "VacanteDiscapacidad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteConocimientosCompetencia",
                table: "VacanteConocimientosCompetencia",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteConocimientosCompetencia_Vacante_VacanteId",
                table: "VacanteConocimientosCompetencia",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteDiscapacidad_Vacante_VacanteId",
                table: "VacanteDiscapacidad",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteHabilidadesdDestreza_Vacante_VacanteId",
                table: "VacanteHabilidadesdDestreza",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacanteConocimientosCompetencia_Vacante_VacanteId",
                table: "VacanteConocimientosCompetencia");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteDiscapacidad_Vacante_VacanteId",
                table: "VacanteDiscapacidad");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteHabilidadesdDestreza_Vacante_VacanteId",
                table: "VacanteHabilidadesdDestreza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteHabilidadesdDestreza",
                table: "VacanteHabilidadesdDestreza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteDiscapacidad",
                table: "VacanteDiscapacidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteConocimientosCompetencia",
                table: "VacanteConocimientosCompetencia");

            migrationBuilder.RenameTable(
                name: "VacanteHabilidadesdDestreza",
                newName: "VacanteHabilidadesdDestrezas");

            migrationBuilder.RenameTable(
                name: "VacanteDiscapacidad",
                newName: "VacanteDiscapacidades");

            migrationBuilder.RenameTable(
                name: "VacanteConocimientosCompetencia",
                newName: "VacanteConocimientosCompetencias");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteHabilidadesdDestreza_VacanteId",
                table: "VacanteHabilidadesdDestrezas",
                newName: "IX_VacanteHabilidadesdDestrezas_VacanteId");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteDiscapacidad_VacanteId",
                table: "VacanteDiscapacidades",
                newName: "IX_VacanteDiscapacidades_VacanteId");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteConocimientosCompetencia_VacanteId",
                table: "VacanteConocimientosCompetencias",
                newName: "IX_VacanteConocimientosCompetencias_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteHabilidadesdDestrezas",
                table: "VacanteHabilidadesdDestrezas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteDiscapacidades",
                table: "VacanteDiscapacidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteConocimientosCompetencias",
                table: "VacanteConocimientosCompetencias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteConocimientosCompetencias_Vacante_VacanteId",
                table: "VacanteConocimientosCompetencias",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteDiscapacidades_Vacante_VacanteId",
                table: "VacanteDiscapacidades",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteHabilidadesdDestrezas_Vacante_VacanteId",
                table: "VacanteHabilidadesdDestrezas",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
