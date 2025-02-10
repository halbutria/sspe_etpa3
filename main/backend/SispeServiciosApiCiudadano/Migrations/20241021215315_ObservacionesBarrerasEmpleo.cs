using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class ObservacionesBarrerasEmpleo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "BarreraEmpleo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "BarreraEmpleo");
        }
    }
}
