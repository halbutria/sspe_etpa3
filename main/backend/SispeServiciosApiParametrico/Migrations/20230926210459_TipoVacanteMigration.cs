using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class TipoVacanteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoVacanteId",
                table: "criterioMatch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tipoVacante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoVacante", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_criterioMatch_TipoVacanteId",
                table: "criterioMatch",
                column: "TipoVacanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_criterioMatch_tipoVacante_TipoVacanteId",
                table: "criterioMatch",
                column: "TipoVacanteId",
                principalTable: "tipoVacante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_criterioMatch_tipoVacante_TipoVacanteId",
                table: "criterioMatch");

            migrationBuilder.DropTable(
                name: "tipoVacante");

            migrationBuilder.DropIndex(
                name: "IX_criterioMatch_TipoVacanteId",
                table: "criterioMatch");

            migrationBuilder.DropColumn(
                name: "TipoVacanteId",
                table: "criterioMatch");
        }
    }
}
