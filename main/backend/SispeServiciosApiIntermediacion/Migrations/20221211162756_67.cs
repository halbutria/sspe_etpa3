using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedesId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuariosId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.RenameColumn(
                name: "UsuariosId",
                table: "EmpresaSedeResponsable",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "SedesId",
                table: "EmpresaSedeResponsable",
                newName: "SedeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_UsuariosId",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_SedesId",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_SedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedeId",
                table: "EmpresaSedeResponsable",
                column: "SedeId",
                principalTable: "EmpresaSede",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuarioId",
                table: "EmpresaSedeResponsable",
                column: "UsuarioId",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuarioId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "EmpresaSedeResponsable",
                newName: "UsuariosId");

            migrationBuilder.RenameColumn(
                name: "SedeId",
                table: "EmpresaSedeResponsable",
                newName: "SedesId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_UsuarioId",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_UsuariosId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_SedeId",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_SedesId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedesId",
                table: "EmpresaSedeResponsable",
                column: "SedesId",
                principalTable: "EmpresaSede",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuariosId",
                table: "EmpresaSedeResponsable",
                column: "UsuariosId",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }
    }
}
