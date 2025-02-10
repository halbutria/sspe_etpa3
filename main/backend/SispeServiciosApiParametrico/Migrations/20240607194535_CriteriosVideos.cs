using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class CriteriosVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_RecepcionNotificaciones_RecepcionNotificacionesId",
                table: "Notificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "RecepcionNotificacionesId",
                table: "Notificaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CriterioVideo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TiempoMaximo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoFormato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterioVideo", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_RecepcionNotificaciones_RecepcionNotificacionesId",
                table: "Notificaciones",
                column: "RecepcionNotificacionesId",
                principalTable: "RecepcionNotificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_RecepcionNotificaciones_RecepcionNotificacionesId",
                table: "Notificaciones");

            migrationBuilder.DropTable(
                name: "CriterioVideo");

            migrationBuilder.AlterColumn<int>(
                name: "RecepcionNotificacionesId",
                table: "Notificaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_RecepcionNotificaciones_RecepcionNotificacionesId",
                table: "Notificaciones",
                column: "RecepcionNotificacionesId",
                principalTable: "RecepcionNotificaciones",
                principalColumn: "Id");
        }
    }
}
