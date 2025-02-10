using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _128 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VacanteZonaGeografica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacanteZonaGeograficaId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteZonaGeografica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacanteZonaGeografica_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VacanteZonaGeografica_VacanteId",
                table: "VacanteZonaGeografica",
                column: "VacanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VacanteZonaGeografica");
        }
    }
}
