using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class CiudadanoInstrumentoBarrerasEmpleo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarreraEmpleo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoBarrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoBarrera = table.Column<int>(type: "int", nullable: true),
                    CodigoPregunta = table.Column<int>(type: "int", nullable: true),
                    CodigoRespuesta = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarreraEmpleo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarreraEmpleo");
        }
    }
}
