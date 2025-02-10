using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class ModuloRespuestasInstrumentoBarrerasEmpleo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Modulos",
                table: "BarreraServicioAlCliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "BarreraServicioAlCliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modulos",
                table: "BarreraManejoTic",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "BarreraManejoTic",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modulos",
                table: "BarreraGerenciaAdministracion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "BarreraGerenciaAdministracion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modulos",
                table: "BarreraFormacion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "BarreraFormacion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modulos",
                table: "BarreraDestrezas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "BarreraDestrezas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modulos",
                table: "BarreraConocimientoEspecifico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "BarreraConocimientoEspecifico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Modulos",
                table: "BarreraServicioAlCliente");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "BarreraServicioAlCliente");

            migrationBuilder.DropColumn(
                name: "Modulos",
                table: "BarreraManejoTic");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "BarreraManejoTic");

            migrationBuilder.DropColumn(
                name: "Modulos",
                table: "BarreraGerenciaAdministracion");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "BarreraGerenciaAdministracion");

            migrationBuilder.DropColumn(
                name: "Modulos",
                table: "BarreraFormacion");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "BarreraFormacion");

            migrationBuilder.DropColumn(
                name: "Modulos",
                table: "BarreraDestrezas");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "BarreraDestrezas");

            migrationBuilder.DropColumn(
                name: "Modulos",
                table: "BarreraConocimientoEspecifico");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "BarreraConocimientoEspecifico");
        }
    }
}
