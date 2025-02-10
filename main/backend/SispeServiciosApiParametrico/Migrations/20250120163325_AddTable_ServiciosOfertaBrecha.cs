using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class AddTable_ServiciosOfertaBrecha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiciosOfertaBrecha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiciosOfertaId = table.Column<int>(type: "int", nullable: false),
                    BrechaServiciosOfertaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciosOfertaBrecha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiciosOfertaBrecha_BrechaServiciosOferta_BrechaServiciosOfertaId",
                        column: x => x.BrechaServiciosOfertaId,
                        principalTable: "BrechaServiciosOferta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiciosOfertaBrecha_ServiciosOferta_ServiciosOfertaId",
                        column: x => x.ServiciosOfertaId,
                        principalTable: "ServiciosOferta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosOfertaBrecha_BrechaServiciosOfertaId",
                table: "ServiciosOfertaBrecha",
                column: "BrechaServiciosOfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosOfertaBrecha_ServiciosOfertaId",
                table: "ServiciosOfertaBrecha",
                column: "ServiciosOfertaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiciosOfertaBrecha");
        }
    }
}
