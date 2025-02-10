using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUsuario_Empresa_EmpresaId",
                table: "EmpresaUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaUsuario_EmpresaId",
                table: "EmpresaUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_EmpresaId",
                table: "EmpresaUsuario",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUsuario_Empresa_EmpresaId",
                table: "EmpresaUsuario",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
