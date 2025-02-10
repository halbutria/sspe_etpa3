using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsuariosId",
                table: "EmpresaSedeResponsable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_UsuariosId",
                table: "EmpresaSedeResponsable",
                column: "UsuariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuariosId",
                table: "EmpresaSedeResponsable",
                column: "UsuariosId",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_UsuariosId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_UsuariosId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "UsuariosId",
                table: "EmpresaSedeResponsable");
        }
    }
}
