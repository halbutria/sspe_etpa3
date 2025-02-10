using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaSede");

            migrationBuilder.RenameColumn(
                name: "ResponsableId",
                table: "EmpresaSede",
                newName: "EmpresaSedeResponsableModelId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSede_ResponsableId",
                table: "EmpresaSede",
                newName: "IX_EmpresaSede_EmpresaSedeResponsableModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                column: "EmpresaSedeResponsableModelId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaSede");

            migrationBuilder.RenameColumn(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                newName: "ResponsableId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSede_EmpresaSedeResponsableModelId",
                table: "EmpresaSede",
                newName: "IX_EmpresaSede_ResponsableId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaSede",
                column: "ResponsableId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }
    }
}
