using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class AddTable_CiudadanoServiciosBasicosBrecha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadanoServiciosBasicosBrecha",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiciosBasicosId = table.Column<int>(type: "int", nullable: false),
                    CodigoServiciosBasicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreServiciosBasicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrechaServiciosBasicosId = table.Column<int>(type: "int", nullable: false),
                    CodigoBrechaServiciosBasicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreBrechaServiciosBasicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_CiudadanoServiciosBasicosBrecha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoServiciosBasicosBrecha_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoServiciosBasicosBrecha_CiudadanoId",
                table: "CiudadanoServiciosBasicosBrecha",
                column: "CiudadanoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoServiciosBasicosBrecha");
        }
    }
}
