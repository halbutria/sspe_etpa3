using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class TipoPreguntas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Opciones",
                table: "Preguntas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoPreguntaId",
                table: "Preguntas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPreguntasId",
                table: "Preguntas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoPreguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPreguntas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_TipoPreguntasId",
                table: "Preguntas",
                column: "TipoPreguntasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preguntas_TipoPreguntas_TipoPreguntasId",
                table: "Preguntas",
                column: "TipoPreguntasId",
                principalTable: "TipoPreguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("SET IDENTITY_INSERT TipoPreguntas ON");

            migrationBuilder.Sql("INSERT INTO TipoPreguntas (Id, Nombre, UsuarioCreacion, FechaCreacion, Eliminado) VALUES (1, 'SI/NO', 'admin', GETDATE(), 0)");
            migrationBuilder.Sql("INSERT INTO TipoPreguntas (Id, Nombre, UsuarioCreacion, FechaCreacion, Eliminado) VALUES (2, 'Abierto', 'admin', GETDATE(), 0)");
            migrationBuilder.Sql("INSERT INTO TipoPreguntas (Id, Nombre, UsuarioCreacion, FechaCreacion, Eliminado) VALUES (3, 'Selección multiple', 'admin', GETDATE(), 0)");
            migrationBuilder.Sql("INSERT INTO TipoPreguntas (Id, Nombre, UsuarioCreacion, FechaCreacion, Eliminado) VALUES (4, 'Selección única', 'admin', GETDATE(), 0)");
            migrationBuilder.Sql("INSERT INTO TipoPreguntas (Id, Nombre, UsuarioCreacion, FechaCreacion, Eliminado) VALUES (5, '1 a 5', 'admin', GETDATE(), 0)");

            migrationBuilder.Sql("SET IDENTITY_INSERT TipoPreguntas OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preguntas_TipoPreguntas_TipoPreguntasId",
                table: "Preguntas");

            migrationBuilder.DropTable(
                name: "TipoPreguntas");

            migrationBuilder.DropIndex(
                name: "IX_Preguntas_TipoPreguntasId",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "Opciones",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "TipoPreguntaId",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "TipoPreguntasId",
                table: "Preguntas");
        }
    }
}
