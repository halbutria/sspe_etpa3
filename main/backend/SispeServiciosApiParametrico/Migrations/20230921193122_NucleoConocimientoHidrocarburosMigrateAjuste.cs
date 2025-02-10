using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class NucleoConocimientoHidrocarburosMigrateAjuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CUOCConocimientoId",
                table: "nucleoConocimientoHidrocarburos",
                newName: "Descripcion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "nucleoConocimientoHidrocarburos",
                newName: "CUOCConocimientoId");
        }
    }
}
