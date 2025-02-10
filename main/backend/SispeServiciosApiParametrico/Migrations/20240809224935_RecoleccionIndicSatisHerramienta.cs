using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class RecoleccionIndicSatisHerramienta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecoleccionIndicSatisHerramienta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecoleccionIndicSatisHerramienta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RespuestasSatisfaccionHerramienta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecoleccionIndicSatisHerramientaId = table.Column<int>(type: "int", nullable: false),
                    IdPregunta = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Pregunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestasSatisfaccionHerramienta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespuestasSatisfaccionHerramienta_RecoleccionIndicSatisHerramienta_RecoleccionIndicSatisHerramientaId",
                        column: x => x.RecoleccionIndicSatisHerramientaId,
                        principalTable: "RecoleccionIndicSatisHerramienta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RespuestasSatisfaccionHerramienta_RecoleccionIndicSatisHerramientaId",
                table: "RespuestasSatisfaccionHerramienta",
                column: "RecoleccionIndicSatisHerramientaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespuestasSatisfaccionHerramienta");

            migrationBuilder.DropTable(
                name: "RecoleccionIndicSatisHerramienta");
        }
    }
}
