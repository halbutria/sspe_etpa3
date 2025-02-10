using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class ServiciosBasicosYEspeciales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadanoServiciosBasicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoServicio = table.Column<int>(type: "int", nullable: false),
                    EstadoServicio = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoServiciosBasicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoServiciosEspeciales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoServicioEspecial = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoTipoServicio = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoServiciosEspeciales", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoServiciosBasicos");

            migrationBuilder.DropTable(
                name: "CiudadanoServiciosEspeciales");
        }
    }
}
