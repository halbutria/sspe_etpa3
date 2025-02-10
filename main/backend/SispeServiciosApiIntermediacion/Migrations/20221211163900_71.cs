using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _71 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeResponsableModel_EmpresaUsuarioModel_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsableModel");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsableModel",
            //    type: "uniqueidentifier",
            //    nullable: true,
            //    oldClrType: typeof(Guid),
            //    oldType: "uniqueidentifier");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_EmpresaSedeResponsableModel_EmpresaUsuarioModel_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsableModel",
            //    column: "EmpresaUsuarioId",
            //    principalTable: "EmpresaUsuarioModel",
            //    principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsableModel_EmpresaUsuarioModel_EmpresaUsuarioId",
                table: "EmpresaSedeResponsableModel");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsableModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsableModel_EmpresaUsuarioModel_EmpresaUsuarioId",
                table: "EmpresaSedeResponsableModel",
                column: "EmpresaUsuarioId",
                principalTable: "EmpresaUsuarioModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
