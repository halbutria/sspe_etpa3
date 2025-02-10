using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class AddTableCurriculumAnnexesModelAnexosHojaDeVida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnexosHojaDeVida",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreArchivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RutaArchivo = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    DescripcionArchivo = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    CodigoArchivo = table.Column<int>(type: "int", nullable: false),
                    TipoBuscador = table.Column<int>(type: "int", nullable: false),
                    NumeroBuscador = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FechaCarga = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcatenacionArchivo = table.Column<int>(type: "int", nullable: false),
                    NombreInterno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ExtensionArchivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnexosHojaDeVida", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnexosHojaDeVida");
        }
    }
}
