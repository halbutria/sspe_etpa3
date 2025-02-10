using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class FixEncuestaSistemaModuloId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaSistema_Modulos_ModuloId",
                table: "EncuestaSistema");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropIndex(
                name: "IX_EncuestaSistema_ModuloId",
                table: "EncuestaSistema");

            migrationBuilder.DropColumn(
                name: "ModuloId",
                table: "EncuestaSistema");

            migrationBuilder.AddColumn<Guid>(
                name: "ModuloId",
                table: "EncuestaSistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: Guid.NewGuid());

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaSistema_Modulo_ModuloId",
                table: "EncuestaSistema",
                column: "ModuloId",
                principalTable: "Modulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaSistema_ModuloId",
                table: "EncuestaSistema",
                column: "ModuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaSistema_Modulo_ModuloId",
                table: "EncuestaSistema");

            migrationBuilder.AlterColumn<int>(
                name: "ModuloId",
                table: "EncuestaSistema",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaSistema_Modulos_ModuloId",
                table: "EncuestaSistema",
                column: "ModuloId",
                principalTable: "Modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
