using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario",
                column: "EmpresaSedeResponsableModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSede_EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                column: "EmpresaSedeResponsableModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                column: "EmpresaSedeResponsableModelId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario",
                column: "EmpresaSedeResponsableModelId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaSede");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaUsuario_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSede_EmpresaSedeResponsableModelId",
                table: "EmpresaSede");

            migrationBuilder.DropColumn(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario");

            migrationBuilder.DropColumn(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaSede");
        }
    }
}
