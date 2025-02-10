using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class AddTable_CiudadanoServiciosOferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadanoServiciosOferta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiciosOfertaId = table.Column<int>(type: "int", nullable: false),
                    CodigoServiciosOferta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreServiciosOferta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrechaServiciosOfertaId = table.Column<int>(type: "int", nullable: false),
                    CodigoBrechaServiciosOferta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreBrechaServiciosOferta = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_CiudadanoServiciosOferta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoServiciosOferta_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoServiciosOferta_CiudadanoId",
                table: "CiudadanoServiciosOferta",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoServiciosOferta_Eliminado",
                table: "CiudadanoServiciosOferta",
                column: "Eliminado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoServiciosOferta");
        }
    }
}
