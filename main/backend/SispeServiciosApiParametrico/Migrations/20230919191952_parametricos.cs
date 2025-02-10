using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class parametricos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "institucionNivelEducativo");

            migrationBuilder.AddColumn<bool>(
                name: "RegistraInstitucion",
                table: "nivelEducativo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "areaInfluencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areaInfluencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "divisionTerritorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_divisionTerritorial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nucleoConocimientoHidrocarburos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUOCConocimientoId = table.Column<int>(type: "int", nullable: false),
                    CUOCConocimientoId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nucleoConocimientoHidrocarburos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nucleoConocimientoHidrocarburos_CUOCconocimiento_CUOCConocimientoId1",
                        column: x => x.CUOCConocimientoId1,
                        principalTable: "CUOCconocimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "profesion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstitucionId = table.Column<int>(type: "int", nullable: false),
                    CUOCConocimientoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUOCConocimientoId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_profesion_CUOCconocimiento_CUOCConocimientoId1",
                        column: x => x.CUOCConocimientoId1,
                        principalTable: "CUOCconocimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_profesion_institucion_InstitucionId",
                        column: x => x.InstitucionId,
                        principalTable: "institucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nucleoConocimientoHidrocarburos_CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos",
                column: "CUOCConocimientoId1");

            migrationBuilder.CreateIndex(
                name: "IX_profesion_CUOCConocimientoId1",
                table: "profesion",
                column: "CUOCConocimientoId1");

            migrationBuilder.CreateIndex(
                name: "IX_profesion_InstitucionId",
                table: "profesion",
                column: "InstitucionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "areaInfluencia");

            migrationBuilder.DropTable(
                name: "divisionTerritorial");

            migrationBuilder.DropTable(
                name: "nucleoConocimientoHidrocarburos");

            migrationBuilder.DropTable(
                name: "profesion");

            migrationBuilder.DropColumn(
                name: "RegistraInstitucion",
                table: "nivelEducativo");

            migrationBuilder.CreateTable(
                name: "institucionNivelEducativo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    InstitucionId = table.Column<int>(type: "int", nullable: false),
                    NivelEducativoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_institucionNivelEducativo", x => x.Id);
                });
        }
    }
}
