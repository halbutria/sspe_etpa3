using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class AlterTableChangeColumnNameEstadoOnTableNotificacionesAlarmas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "NotificacionesAlarmas",
                newName: "EstadoNotificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstadoNotificacion",
                table: "NotificacionesAlarmas",
                newName: "Estado");
        }
    }
}
