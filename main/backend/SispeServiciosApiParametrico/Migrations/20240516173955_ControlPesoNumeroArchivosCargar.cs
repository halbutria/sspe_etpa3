using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class ControlPesoNumeroArchivosCargar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlPesoNumeroArchivosCargar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidadAdjuntosHv = table.Column<int>(type: "int", nullable: false),
                    pesoMaximoArchivoAdjuntoHv = table.Column<int>(type: "int", nullable: false),
                    cantidadAdjuntosInformacionAcademica = table.Column<int>(type: "int", nullable: false),
                    pesoMaximoArchivoAdjuntoInformacionAcademica = table.Column<int>(type: "int", nullable: false),
                    cantidadAdjuntosInformacionLaboral = table.Column<int>(type: "int", nullable: false),
                    pesoMaximoArchivoAdjuntoInformacionLaboral = table.Column<int>(type: "int", nullable: false),
                    cantidadAdjuntosEducacionInformal = table.Column<int>(type: "int", nullable: false),
                    pesoMaximoArchivoAdjuntoEducacionInformal = table.Column<int>(type: "int", nullable: false),
                    cantidadAdjuntosIdiomas = table.Column<int>(type: "int", nullable: false),
                    pesoMaximoArchivoAdjuntoIdiomas = table.Column<int>(type: "int", nullable: false),
                    pesoMaximoArchivoAdjuntoFoto = table.Column<int>(type: "int", nullable: false),
                    cantidadEnlacesPermitidos = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlPesoNumeroArchivosCargar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlPesoNumeroArchivosCargar");
        }
    }
}
