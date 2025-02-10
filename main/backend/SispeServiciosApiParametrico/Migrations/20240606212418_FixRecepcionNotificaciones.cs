using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class FixRecepcionNotificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "RecepcionNotificaciones");

            migrationBuilder.DropColumn(
                name: "Notificacion",
                table: "RecepcionNotificaciones");

            migrationBuilder.RenameColumn(
                name: "Tema",
                table: "RecepcionNotificaciones",
                newName: "Nombre");

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    RecepcionNotificacionesId = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificaciones_RecepcionNotificaciones_RecepcionNotificacionesId",
                        column: x => x.RecepcionNotificacionesId,
                        principalTable: "RecepcionNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_RecepcionNotificacionesId",
                table: "Notificaciones",
                column: "RecepcionNotificacionesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "RecepcionNotificaciones",
                newName: "Tema");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "RecepcionNotificaciones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Notificacion",
                table: "RecepcionNotificaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
