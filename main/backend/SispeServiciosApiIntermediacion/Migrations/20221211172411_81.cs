using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class _81 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeModel_Empresa_EmpresaId",
            //    table: "EmpresaSedeModel");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeResponsableModel_EmpresaSedeModel_EmpresaSedeId",
            //    table: "EmpresaSedeResponsableModel");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_EmpresaSedeResponsableModel_EmpresaUsuarioModel_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsableModel");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_EmpresaUsuarioModel",
            //    table: "EmpresaUsuarioModel");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_EmpresaSedeModel",
            //    table: "EmpresaSedeModel");

            //migrationBuilder.RenameTable(
            //    name: "EmpresaUsuarioModel",
            //    newName: "EmpresaUsuario");

            //migrationBuilder.RenameTable(
            //    name: "EmpresaSedeModel",
            //    newName: "EmpresaSede");

            //migrationBuilder.RenameIndex(
            //    name: "IX_EmpresaSedeModel_EmpresaId",
            //    table: "EmpresaSede",
            //    newName: "IX_EmpresaSede_EmpresaId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_EmpresaUsuario",
            //    table: "EmpresaUsuario",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_EmpresaSede",
            //    table: "EmpresaSede",
            //    column: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_EmpresaSede_Empresa_EmpresaId",
            //    table: "EmpresaSede",
            //    column: "EmpresaId",
            //    principalTable: "Empresa",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_EmpresaSedeResponsableModel_EmpresaSede_EmpresaSedeId",
            //    table: "EmpresaSedeResponsableModel",
            //    column: "EmpresaSedeId",
            //    principalTable: "EmpresaSede",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_EmpresaSedeResponsableModel_EmpresaUsuario_EmpresaUsuarioId",
            //    table: "EmpresaSedeResponsableModel",
            //    column: "EmpresaUsuarioId",
            //    principalTable: "EmpresaUsuario",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSede_Empresa_EmpresaId",
                table: "EmpresaSede");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsableModel_EmpresaSede_EmpresaSedeId",
                table: "EmpresaSedeResponsableModel");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaSedeResponsableModel_EmpresaUsuario_EmpresaUsuarioId",
                table: "EmpresaSedeResponsableModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpresaUsuario",
                table: "EmpresaUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpresaSede",
                table: "EmpresaSede");

            migrationBuilder.RenameTable(
                name: "EmpresaUsuario",
                newName: "EmpresaUsuarioModel");

            migrationBuilder.RenameTable(
                name: "EmpresaSede",
                newName: "EmpresaSedeModel");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaSede_EmpresaId",
                table: "EmpresaSedeModel",
                newName: "IX_EmpresaSedeModel_EmpresaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpresaUsuarioModel",
                table: "EmpresaUsuarioModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpresaSedeModel",
                table: "EmpresaSedeModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeModel_Empresa_EmpresaId",
                table: "EmpresaSedeModel",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsableModel_EmpresaSedeModel_EmpresaSedeId",
                table: "EmpresaSedeResponsableModel",
                column: "EmpresaSedeId",
                principalTable: "EmpresaSedeModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaSedeResponsableModel_EmpresaUsuarioModel_EmpresaUsuarioId",
                table: "EmpresaSedeResponsableModel",
                column: "EmpresaUsuarioId",
                principalTable: "EmpresaUsuarioModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
