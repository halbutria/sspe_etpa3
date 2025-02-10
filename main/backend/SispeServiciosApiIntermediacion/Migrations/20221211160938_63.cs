using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaSede");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSede_ResponsableId",
                table: "EmpresaSede");

            migrationBuilder.DropColumn(
                name: "ResponsableId",
                table: "EmpresaSede");

            migrationBuilder.AddColumn<int>(
                name: "SedesId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_SedesId",
                table: "EmpresaSedeResponsable",
                column: "SedesId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedesId",
                table: "EmpresaSedeResponsable",
                column: "SedesId",
                principalTable: "EmpresaSede",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsable_EmpresaSede_SedesId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSedeResponsable_SedesId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "SedesId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsableId",
                table: "EmpresaSede",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSede_ResponsableId",
                table: "EmpresaSede",
                column: "ResponsableId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaSede",
                column: "ResponsableId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }
    }
}
