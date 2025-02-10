using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class CiudadanoPQRSDF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPQRSDF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPQRSDF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoPQRSDF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prestador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPQRSDFId = table.Column<int>(type: "int", nullable: false),
                    HechosPQR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Radicado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoPQRSDF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoPQRSDF_TipoPQRSDF_TipoPQRSDFId",
                        column: x => x.TipoPQRSDFId,
                        principalTable: "TipoPQRSDF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoPQRSDF_TipoPQRSDFId",
                table: "CiudadanoPQRSDF",
                column: "TipoPQRSDFId");

            migrationBuilder.Sql("SET IDENTITY_INSERT TipoPQRSDF ON");

            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (1, 'Petición', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (2, 'Queja', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (3, 'Reclamos', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (4, 'Sugerencia', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (5, 'Denuncia', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (6, 'Felicitación', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (7, 'Recurso de Reposición', 0)");
            migrationBuilder.Sql("INSERT INTO TipoPQRSDF (Id, Descripcion, Eliminado) VALUES (8, 'Recurso de Apelación', 0)");

            migrationBuilder.Sql("SET IDENTITY_INSERT TipoPQRSDF OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoPQRSDF");

            migrationBuilder.DropTable(
                name: "TipoPQRSDF");
        }
    }
}
