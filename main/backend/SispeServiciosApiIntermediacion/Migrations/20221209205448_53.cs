using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpresaSedeUsuarioId",
                table: "EmpresaSedeResponsable",
                newName: "EmpresaUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpresaUsuarioId",
                table: "EmpresaSedeResponsable",
                newName: "EmpresaSedeUsuarioId");
        }
    }
}
