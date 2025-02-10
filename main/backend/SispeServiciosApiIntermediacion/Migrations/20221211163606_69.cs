using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _69 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId1",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.DropIndex(
            //    name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId1",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.DropColumn(
            //    name: "EmpresaUsuarioId1",
            //    table: "EmpresaSedeResponsable");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsable",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId1",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioId1",
                principalTable: "EmpresaUsuario",
                principalColumn: "Id");
        }
    }
}
