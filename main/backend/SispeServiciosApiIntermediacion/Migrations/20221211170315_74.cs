using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _74 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.RenameColumn(
            //    name: "EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable",
            //    newName: "EmpresaUsuarioModelId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable",
            //    newName: "IX_EmpresaSedeResponsable_EmpresaUsuarioModelId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioModelId",
            //    table: "EmpresaSedeResponsable",
            //    column: "EmpresaUsuarioModelId",
            //    principalTable: "EmpresaUsuario",
            //    principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioModelId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.RenameColumn(
                name: "EmpresaUsuarioModelId",
                table: "EmpresaSedeResponsable",
                newName: "EmpresaUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaUsuarioModelId",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_EmpresaUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioId",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }
    }
}
