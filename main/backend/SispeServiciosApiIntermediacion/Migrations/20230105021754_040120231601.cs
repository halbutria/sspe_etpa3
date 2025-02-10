using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _040120231601 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacanteZonaGeografica",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacanteUbicacion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacantePoblacionVulnerable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacanteMotivoExcepcionalidad",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacanteDiscapacidad",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacanteDenominacionRelacionada",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "VacanteCambioEstado",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "EmpresaUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "EmpresaSedeUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "EmpresaSede",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarga",
                table: "Empresa",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacanteZonaGeografica");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacanteUbicacion");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacantePoblacionVulnerable");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacanteMotivoExcepcionalidad");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacanteDiscapacidad");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacanteDenominacionRelacionada");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "VacanteCambioEstado");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "EmpresaUsuario");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "EmpresaSedeUsuario");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "EmpresaSede");

            migrationBuilder.DropColumn(
                name: "IdCarga",
                table: "Empresa");
        }
    }
}
