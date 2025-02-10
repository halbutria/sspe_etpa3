using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class NucleoConocimientoHidrocarburosMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nucleoConocimientoHidrocarburos_CUOCconocimiento_CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos");

            migrationBuilder.DropIndex(
                name: "IX_nucleoConocimientoHidrocarburos_CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos");

            migrationBuilder.DropColumn(
                name: "CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos");

            migrationBuilder.AlterColumn<string>(
                name: "CUOCConocimientoId",
                table: "nucleoConocimientoHidrocarburos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CUOCConocimientoId",
                table: "nucleoConocimientoHidrocarburos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_nucleoConocimientoHidrocarburos_CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos",
                column: "CUOCConocimientoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_nucleoConocimientoHidrocarburos_CUOCconocimiento_CUOCConocimientoId1",
                table: "nucleoConocimientoHidrocarburos",
                column: "CUOCConocimientoId1",
                principalTable: "CUOCconocimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
