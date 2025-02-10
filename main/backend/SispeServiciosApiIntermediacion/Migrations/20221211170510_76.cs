using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _76 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EsPrincipal",
                table: "EmpresaSedeResponsable");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaSedeModelId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaSedeModelId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaSedeModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_EmpresaSedeModelId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaSedeModelId",
                principalTable: "EmpresaSede",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_EmpresaSedeModelId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaSedeModelId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EmpresaSedeModelId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaSedeId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EsPrincipal",
                table: "EmpresaSedeResponsable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaSedeId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaSedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_EmpresaSedeId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaSedeId",
                principalTable: "EmpresaSede",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
