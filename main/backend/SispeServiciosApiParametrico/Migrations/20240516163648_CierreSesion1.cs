using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class CierreSesion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tiempoInactividad",
                table: "CierreSesion",
                newName: "TiempoInactividad");

            migrationBuilder.RenameColumn(
                name: "tiempoActividad",
                table: "CierreSesion",
                newName: "TiempoActividad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TiempoInactividad",
                table: "CierreSesion",
                newName: "tiempoInactividad");

            migrationBuilder.RenameColumn(
                name: "TiempoActividad",
                table: "CierreSesion",
                newName: "tiempoActividad");
        }
    }
}
