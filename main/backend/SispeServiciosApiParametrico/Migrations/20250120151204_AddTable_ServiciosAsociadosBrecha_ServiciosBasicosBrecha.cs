using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class AddTable_ServiciosAsociadosBrecha_ServiciosBasicosBrecha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiciosAsociadosBrecha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiciosAsociadosId = table.Column<int>(type: "int", nullable: false),
                    BrechaServiciosAsociadosId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciosAsociadosBrecha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiciosAsociadosBrecha_BrechaServiciosAsociados_BrechaServiciosAsociadosId",
                        column: x => x.BrechaServiciosAsociadosId,
                        principalTable: "BrechaServiciosAsociados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiciosAsociadosBrecha_ServiciosAsociados_ServiciosAsociadosId",
                        column: x => x.ServiciosAsociadosId,
                        principalTable: "ServiciosAsociados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiciosBasicosBrecha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiciosBasicosId = table.Column<int>(type: "int", nullable: false),
                    BrechaServiciosBasicosId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciosBasicosBrecha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiciosBasicosBrecha_BrechaServiciosBasicos_BrechaServiciosBasicosId",
                        column: x => x.BrechaServiciosBasicosId,
                        principalTable: "BrechaServiciosBasicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiciosBasicosBrecha_ServiciosBasicos_ServiciosBasicosId",
                        column: x => x.ServiciosBasicosId,
                        principalTable: "ServiciosBasicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosAsociadosBrecha_BrechaServiciosAsociadosId",
                table: "ServiciosAsociadosBrecha",
                column: "BrechaServiciosAsociadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosAsociadosBrecha_ServiciosAsociadosId",
                table: "ServiciosAsociadosBrecha",
                column: "ServiciosAsociadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosBasicosBrecha_BrechaServiciosBasicosId",
                table: "ServiciosBasicosBrecha",
                column: "BrechaServiciosBasicosId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosBasicosBrecha_ServiciosBasicosId",
                table: "ServiciosBasicosBrecha",
                column: "ServiciosBasicosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiciosAsociadosBrecha");

            migrationBuilder.DropTable(
                name: "ServiciosBasicosBrecha");
        }
    }
}
