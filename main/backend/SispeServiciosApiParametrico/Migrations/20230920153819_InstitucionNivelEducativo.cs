using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class InstitucionNivelEducativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profesion_CUOCconocimiento_CUOCConocimientoId1",
                table: "profesion");

            migrationBuilder.DropIndex(
                name: "IX_profesion_CUOCConocimientoId1",
                table: "profesion");

            migrationBuilder.DropColumn(
                name: "CUOCConocimientoId1",
                table: "profesion");

            migrationBuilder.RenameColumn(
                name: "CUOCConocimientoId",
                table: "profesion",
                newName: "AreaConocimientoId");

            migrationBuilder.CreateTable(
                name: "institucionNivelEducativo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstitucionId = table.Column<int>(type: "int", nullable: false),
                    NivelEducativoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_institucionNivelEducativo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_institucionNivelEducativo_institucion_InstitucionId",
                        column: x => x.InstitucionId,
                        principalTable: "institucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_institucionNivelEducativo_nivelEducativo_NivelEducativoId",
                        column: x => x.NivelEducativoId,
                        principalTable: "nivelEducativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_profesion_AreaConocimientoId",
                table: "profesion",
                column: "AreaConocimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_institucionNivelEducativo_InstitucionId",
                table: "institucionNivelEducativo",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_institucionNivelEducativo_NivelEducativoId",
                table: "institucionNivelEducativo",
                column: "NivelEducativoId");

            migrationBuilder.AddForeignKey(
                name: "FK_profesion_areaConocimiento_AreaConocimientoId",
                table: "profesion",
                column: "AreaConocimientoId",
                principalTable: "areaConocimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profesion_areaConocimiento_AreaConocimientoId",
                table: "profesion");

            migrationBuilder.DropTable(
                name: "institucionNivelEducativo");

            migrationBuilder.DropIndex(
                name: "IX_profesion_AreaConocimientoId",
                table: "profesion");

            migrationBuilder.RenameColumn(
                name: "AreaConocimientoId",
                table: "profesion",
                newName: "CUOCConocimientoId");

            migrationBuilder.AddColumn<string>(
                name: "CUOCConocimientoId1",
                table: "profesion",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_profesion_CUOCConocimientoId1",
                table: "profesion",
                column: "CUOCConocimientoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_profesion_CUOCconocimiento_CUOCConocimientoId1",
                table: "profesion",
                column: "CUOCConocimientoId1",
                principalTable: "CUOCconocimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
