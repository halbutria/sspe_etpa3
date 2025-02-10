using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacante_VacanteEstados_EstadoId",
                table: "Vacante");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteHabilidadesdDestreza_Vacante_VacanteId",
                table: "VacanteHabilidadesdDestreza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteHabilidadesdDestreza",
                table: "VacanteHabilidadesdDestreza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteEstados",
                table: "VacanteEstados");

            migrationBuilder.RenameTable(
                name: "VacanteHabilidadesdDestreza",
                newName: "VacanteHabilidadDestreza");

            migrationBuilder.RenameTable(
                name: "VacanteEstados",
                newName: "VacanteEstado");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteHabilidadesdDestreza_VacanteId",
                table: "VacanteHabilidadDestreza",
                newName: "IX_VacanteHabilidadDestreza_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteHabilidadDestreza",
                table: "VacanteHabilidadDestreza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteEstado",
                table: "VacanteEstado",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacante_VacanteEstado_EstadoId",
                table: "Vacante",
                column: "EstadoId",
                principalTable: "VacanteEstado",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteHabilidadDestreza_Vacante_VacanteId",
                table: "VacanteHabilidadDestreza",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacante_VacanteEstado_EstadoId",
                table: "Vacante");

            migrationBuilder.DropForeignKey(
                name: "FK_VacanteHabilidadDestreza_Vacante_VacanteId",
                table: "VacanteHabilidadDestreza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteHabilidadDestreza",
                table: "VacanteHabilidadDestreza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacanteEstado",
                table: "VacanteEstado");

            migrationBuilder.RenameTable(
                name: "VacanteHabilidadDestreza",
                newName: "VacanteHabilidadesdDestreza");

            migrationBuilder.RenameTable(
                name: "VacanteEstado",
                newName: "VacanteEstados");

            migrationBuilder.RenameIndex(
                name: "IX_VacanteHabilidadDestreza_VacanteId",
                table: "VacanteHabilidadesdDestreza",
                newName: "IX_VacanteHabilidadesdDestreza_VacanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteHabilidadesdDestreza",
                table: "VacanteHabilidadesdDestreza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacanteEstados",
                table: "VacanteEstados",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacante_VacanteEstados_EstadoId",
                table: "Vacante",
                column: "EstadoId",
                principalTable: "VacanteEstados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacanteHabilidadesdDestreza_Vacante_VacanteId",
                table: "VacanteHabilidadesdDestreza",
                column: "VacanteId",
                principalTable: "Vacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
