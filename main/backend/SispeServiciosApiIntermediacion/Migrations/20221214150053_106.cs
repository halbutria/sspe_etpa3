using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _106 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaSedeResponsable");

            migrationBuilder.CreateTable(
                name: "EmpresaSedeUsuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaSedeId = table.Column<int>(type: "int", nullable: false),
                    EmpresaUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsPrincipal = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaSedeUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaSedeUsuario_EmpresaSede_EmpresaSedeId",
                        column: x => x.EmpresaSedeId,
                        principalTable: "EmpresaSede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaSedeUsuario_EmpresaUsuario_EmpresaUsuarioId",
                        column: x => x.EmpresaUsuarioId,
                        principalTable: "EmpresaUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeUsuario_EmpresaSedeId",
                table: "EmpresaSedeUsuario",
                column: "EmpresaSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeUsuario_EmpresaUsuarioId",
                table: "EmpresaSedeUsuario",
                column: "EmpresaUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaSedeUsuario");

            migrationBuilder.CreateTable(
                name: "EmpresaSedeResponsable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaSedeId = table.Column<int>(type: "int", nullable: false),
                    EmpresaUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    EsPrincipal = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaSedeResponsable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaSedeResponsable_EmpresaSede_EmpresaSedeId",
                        column: x => x.EmpresaSedeId,
                        principalTable: "EmpresaSede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaSedeResponsable_EmpresaUsuario_EmpresaUsuarioId",
                        column: x => x.EmpresaUsuarioId,
                        principalTable: "EmpresaUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaSedeId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSedeResponsable_EmpresaUsuarioId",
                table: "EmpresaSedeResponsable",
                column: "EmpresaUsuarioId");
        }
    }
}
