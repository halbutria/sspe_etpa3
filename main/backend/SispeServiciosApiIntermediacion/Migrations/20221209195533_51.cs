using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaResponsable");

            migrationBuilder.CreateTable(
                name: "EmpresaSedeResponsable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaSedeId = table.Column<int>(type: "int", nullable: false),
                    EmpresaSedeUsuarioId = table.Column<int>(type: "int", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaSedeResponsable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaSede",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaSede", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaSede_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaSede_EmpresaSedeResponsable_ResponsableId",
                        column: x => x.ResponsableId,
                        principalTable: "EmpresaSedeResponsable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpresaUsuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaUsuario_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaUsuario_EmpresaSedeResponsable_ResponsableId",
                        column: x => x.ResponsableId,
                        principalTable: "EmpresaSedeResponsable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSede_EmpresaId",
                table: "EmpresaSede",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSede_ResponsableId",
                table: "EmpresaSede",
                column: "ResponsableId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_EmpresaId",
                table: "EmpresaUsuario",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_ResponsableId",
                table: "EmpresaUsuario",
                column: "ResponsableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaSede");

            migrationBuilder.DropTable(
                name: "EmpresaUsuario");

            migrationBuilder.DropTable(
                name: "EmpresaSedeResponsable");

            migrationBuilder.CreateTable(
                name: "EmpresaResponsable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaResponsable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaResponsable_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsable_EmpresaId",
                table: "EmpresaResponsable",
                column: "EmpresaId");
        }
    }
}
