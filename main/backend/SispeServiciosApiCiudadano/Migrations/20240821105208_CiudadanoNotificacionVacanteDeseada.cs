using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class CiudadanoNotificacionVacanteDeseada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadanoNotificacionVacanteDeseada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoNotificacionVacanteDeseada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoCriteriosNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudadanoNotificacionVacanteDeseadaId = table.Column<int>(type: "int", nullable: false),
                    Filtro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoCriteriosNotificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoCriteriosNotificaciones_CiudadanoNotificacionVacanteDeseada_CiudadanoNotificacionVacanteDeseadaId",
                        column: x => x.CiudadanoNotificacionVacanteDeseadaId,
                        principalTable: "CiudadanoNotificacionVacanteDeseada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoCriteriosNotificaciones_CiudadanoNotificacionVacanteDeseadaId",
                table: "CiudadanoCriteriosNotificaciones",
                column: "CiudadanoNotificacionVacanteDeseadaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoCriteriosNotificaciones");

            migrationBuilder.DropTable(
                name: "CiudadanoNotificacionVacanteDeseada");
        }
    }
}
