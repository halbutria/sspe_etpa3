using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _79 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioModelId",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.DropIndex(
            //    name: "IX_EmpresaSedeResponsable_EmpresaUsuarioModelId",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.DropColumn(
            //    name: "EmpresaUsuarioModelId",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.AddColumn<Guid>(
            //    name: "EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.CreateIndex(
            //    name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable",
            //    column: "EmpresaUsuarioId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable",
            //    column: "EmpresaUsuarioId",
            //    principalTable: "EmpresaUsuario",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaUsuarioModelId",
                table: "EmpresaSedeResponsable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaUsuarioModelId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioModelId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioModelId",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }
    }
}
