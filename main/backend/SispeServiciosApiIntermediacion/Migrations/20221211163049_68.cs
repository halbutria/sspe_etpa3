using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _68 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuarioId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_SedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "SedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "EmpresaSedeResponsable",
                newName: "EmpresaUsuarioId1");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_UsuarioId",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_EmpresaUsuarioId1");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaSedeId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioId1",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.RenameColumn(
                name: "EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable",
                newName: "IX_EmpresaSedeResponsable_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "SedeId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_SedeId",
                table: "EmpresaSedeResponsable",
                column: "SedeId");

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
    }
}
