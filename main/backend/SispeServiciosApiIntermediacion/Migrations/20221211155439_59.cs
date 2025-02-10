using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _59 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaSede");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario");

            migrationBuilder.RenameColumn(
                name: "EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario",
                newName: "ResponsableId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaUsuario_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario",
                newName: "IX_EmpresaUsuario_ResponsableId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaUsuario",
                column: "ResponsableId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaSede");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_ResponsableId",
                table: "EmpresaUsuario");

            migrationBuilder.RenameColumn(
                name: "ResponsableId",
                table: "EmpresaUsuario",
                newName: "EmpresaSedeResponsableModelId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaUsuario_ResponsableId",
                table: "EmpresaUsuario",
                newName: "IX_EmpresaUsuario_EmpresaSedeResponsableModelId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUsuario_EmpresaSedeResponsable_EmpresaSedeResponsableModelId",
                table: "EmpresaUsuario",
                column: "EmpresaSedeResponsableModelId",
                principalTable: "EmpresaSedeResponsable",
                principalColumn: "Id");
        }
    }
}
