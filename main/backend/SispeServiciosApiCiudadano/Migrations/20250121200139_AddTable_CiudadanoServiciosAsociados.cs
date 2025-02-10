using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class AddTable_CiudadanoServiciosAsociados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadanoServiciosAsociados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiciosAsociadosId = table.Column<int>(type: "int", nullable: false),
                    CodigoServiciosAsociados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreServiciosAsociados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrechaServiciosAsociadosId = table.Column<int>(type: "int", nullable: false),
                    CodigoBrechaServiciosAsociados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreBrechaServiciosAsociados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Seguimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoServiciosAsociados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoServiciosAsociados_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoServiciosAsociados_CiudadanoId",
                table: "CiudadanoServiciosAsociados",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoServiciosAsociados_Eliminado",
                table: "CiudadanoServiciosAsociados",
                column: "Eliminado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoServiciosAsociados");
        }
    }
}
