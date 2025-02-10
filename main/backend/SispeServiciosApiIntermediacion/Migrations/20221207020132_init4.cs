using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UbicacionId",
                table: "Vacante");

            migrationBuilder.CreateTable(
                name: "VacantesUbicaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartamentoID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadComuna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroPuesto = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacantesUbicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacantesUbicaciones_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VacantesUbicaciones_VacanteId",
                table: "VacantesUbicaciones",
                column: "VacanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VacantesUbicaciones");

            migrationBuilder.AddColumn<int>(
                name: "UbicacionId",
                table: "Vacante",
                type: "int",
                nullable: true);
        }
    }
}
