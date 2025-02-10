using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _60 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaUsuario_ResponsableId",
                table: "EmpresaUsuario");

            migrationBuilder.DropColumn(
                name: "ResponsableId",
                table: "EmpresaUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ResponsableId",
                table: "EmpresaUsuario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_ResponsableId",
                table: "EmpresaUsuario",
                column: "ResponsableId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaUsuario",
                column: "ResponsableId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }
    }
}
