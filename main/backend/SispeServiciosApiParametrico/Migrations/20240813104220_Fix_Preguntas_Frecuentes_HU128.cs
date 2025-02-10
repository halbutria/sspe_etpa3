using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class Fix_Preguntas_Frecuentes_HU128 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ModuloId",
                table: "PreguntasFrecuentes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PreguntasFrecuentes_ModuloId",
                table: "PreguntasFrecuentes",
                column: "ModuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreguntasFrecuentes_Modulo_ModuloId",
                table: "PreguntasFrecuentes",
                column: "ModuloId",
                principalTable: "Modulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreguntasFrecuentes_Modulo_ModuloId",
                table: "PreguntasFrecuentes");

            migrationBuilder.DropIndex(
                name: "IX_PreguntasFrecuentes_ModuloId",
                table: "PreguntasFrecuentes");

            migrationBuilder.DropColumn(
                name: "ModuloId",
                table: "PreguntasFrecuentes");
        }
    }
}
