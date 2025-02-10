using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaSede");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaSede_EmpresaSedeResponsableModelId",
                table: "EmpresaSede");

            migrationBuilder.DropColumn(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaSede");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                type: "uniqueidentifier",
                nullable: true);

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
        }
    }
}
