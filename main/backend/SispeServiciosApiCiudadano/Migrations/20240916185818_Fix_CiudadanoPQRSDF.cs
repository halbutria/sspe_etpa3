using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class Fix_CiudadanoPQRSDF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Radicado",
                table: "CiudadanoPQRSDF",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Radicado",
                table: "CiudadanoPQRSDF",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
