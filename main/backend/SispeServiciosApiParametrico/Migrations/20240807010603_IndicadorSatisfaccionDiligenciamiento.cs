using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class IndicadorSatisfaccionDiligenciamiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndicadorSatisfaccionDiligenciamiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TipoPreguntasId = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    Opciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicadorSatisfaccionDiligenciamiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndicadorSatisfaccionDiligenciamiento_TipoPreguntas_TipoPreguntasId",
                        column: x => x.TipoPreguntasId,
                        principalTable: "TipoPreguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndicadorSatisfaccionDiligenciamiento_TipoPreguntasId",
                table: "IndicadorSatisfaccionDiligenciamiento",
                column: "TipoPreguntasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicadorSatisfaccionDiligenciamiento");
        }
    }
}
