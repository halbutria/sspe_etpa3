using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _65 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpresaSedeId",
                table: "EmpresaSedeResponsable");

            migrationBuilder.DropColumn(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaSedeId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
