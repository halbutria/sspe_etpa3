using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class FixInactivarCuentaEmpresarial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoRespuesta",
                table: "InactivarCuentaEmpresarial");

            migrationBuilder.AddColumn<string>(
                name: "Opciones",
                table: "InactivarCuentaEmpresarial",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoPreguntasId",
                table: "InactivarCuentaEmpresarial",
                type: "int",
                maxLength: 60,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InactivarCuentaEmpresarial_TipoPreguntasId",
                table: "InactivarCuentaEmpresarial",
                column: "TipoPreguntasId");

            migrationBuilder.AddForeignKey(
                name: "FK_InactivarCuentaEmpresarial_TipoPreguntas_TipoPreguntasId",
                table: "InactivarCuentaEmpresarial",
                column: "TipoPreguntasId",
                principalTable: "TipoPreguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InactivarCuentaEmpresarial_TipoPreguntas_TipoPreguntasId",
                table: "InactivarCuentaEmpresarial");

            migrationBuilder.DropIndex(
                name: "IX_InactivarCuentaEmpresarial_TipoPreguntasId",
                table: "InactivarCuentaEmpresarial");

            migrationBuilder.DropColumn(
                name: "Opciones",
                table: "InactivarCuentaEmpresarial");

            migrationBuilder.DropColumn(
                name: "TipoPreguntasId",
                table: "InactivarCuentaEmpresarial");

            migrationBuilder.AddColumn<string>(
                name: "TipoRespuesta",
                table: "InactivarCuentaEmpresarial",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }
    }
}
