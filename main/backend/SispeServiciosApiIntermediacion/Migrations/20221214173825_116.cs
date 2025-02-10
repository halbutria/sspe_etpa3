using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _116 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoInternoVacante",
                table: "Vacante",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ManoObraCalificada",
                table: "Vacante",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PerteneceARural",
                table: "Vacante",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PriorizarPoblacionVulnerable",
                table: "Vacante",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PriorizarZonaRural",
                table: "Vacante",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RangoRemitirCandidatoFinal",
                table: "Vacante",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RangoRemitirCandidatoInicial",
                table: "Vacante",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RegistroVacanteDemasPrestadores",
                table: "Vacante",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TieneVideoAdjunto",
                table: "Vacante",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoProyecto",
                table: "Vacante",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoInternoVacante",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "ManoObraCalificada",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "PerteneceARural",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "PriorizarPoblacionVulnerable",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "PriorizarZonaRural",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "RangoRemitirCandidatoFinal",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "RangoRemitirCandidatoInicial",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "RegistroVacanteDemasPrestadores",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "TieneVideoAdjunto",
                table: "Vacante");

            migrationBuilder.DropColumn(
                name: "TipoProyecto",
                table: "Vacante");
        }
    }
}
