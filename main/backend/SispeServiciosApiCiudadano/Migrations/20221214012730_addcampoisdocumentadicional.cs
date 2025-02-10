using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Ciudadano.Migrations
{
    public partial class addcampoisdocumentadicional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoCargoInteres_Ciudadano_CiudadanoId",
                table: "CiudadanoCargoInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoConocimientoCompetencia_Ciudadano_CiudadanoId",
                table: "CiudadanoConocimientoCompetencia");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoEducacionFormal_Ciudadano_CiudadanoId",
                table: "CiudadanoEducacionFormal");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoEducacionNoFormal_Ciudadano_CiudadanoId",
                table: "CiudadanoEducacionNoFormal");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoExperiencia_Ciudadano_CiudadanoId",
                table: "CiudadanoExperiencia");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoHabilidadDestreza_Ciudadano_CiudadanoId",
                table: "CiudadanoHabilidadDestreza");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoIdioma_Ciudadano_CiudadanoId",
                table: "CiudadanoIdioma");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoInformacionLaboral_Ciudadano_CiudadanoId",
                table: "CiudadanoInformacionLaboral");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoRedesSociales_Ciudadano_CiudadanoId",
                table: "CiudadanoRedesSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoTipoNotificacion_Ciudadano_CiudadanoId",
                table: "CiudadanoTipoNotificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoTipoNotificacion",
                table: "CiudadanoTipoNotificacion")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoInformacionLaboral",
                table: "CiudadanoInformacionLaboral")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoIdioma",
                table: "CiudadanoIdioma")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoHabilidadDestreza",
                table: "CiudadanoHabilidadDestreza")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoExperiencia",
                table: "CiudadanoExperiencia")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoEducacionFormal",
                table: "CiudadanoEducacionFormal")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoConocimientoCompetencia",
                table: "CiudadanoConocimientoCompetencia")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoCargoInteres",
                table: "CiudadanoCargoInteres")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudadano",
                table: "Ciudadano")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameTable(
                name: "CiudadanoTipoNotificacion",
                newName: "CiudadanoTipoNotificacionModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoInformacionLaboral",
                newName: "CiudadanoInformacionLaboralModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoIdioma",
                newName: "CiudadanoIdiomaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoHabilidadDestreza",
                newName: "CiudadanoHabilidadDestrezaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoExperiencia",
                newName: "CiudadanoExperienciaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoEducacionFormal",
                newName: "CiudadanoEducacionFormalModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoConocimientoCompetencia",
                newName: "CiudadanoConocimientoCompetenciaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoCargoInteres",
                newName: "CiudadanoCargoInteresModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "Ciudadano",
                newName: "CiudadanoModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoTipoNotificacion_CiudadanoId",
                table: "CiudadanoTipoNotificacionModel",
                newName: "IX_CiudadanoTipoNotificacionModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoInformacionLaboral_CiudadanoId",
                table: "CiudadanoInformacionLaboralModel",
                newName: "IX_CiudadanoInformacionLaboralModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoIdioma_CiudadanoId",
                table: "CiudadanoIdiomaModel",
                newName: "IX_CiudadanoIdiomaModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoHabilidadDestreza_CiudadanoId",
                table: "CiudadanoHabilidadDestrezaModel",
                newName: "IX_CiudadanoHabilidadDestrezaModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoExperiencia_CiudadanoId",
                table: "CiudadanoExperienciaModel",
                newName: "IX_CiudadanoExperienciaModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoEducacionFormal_CiudadanoId",
                table: "CiudadanoEducacionFormalModel",
                newName: "IX_CiudadanoEducacionFormalModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoConocimientoCompetencia_CiudadanoId",
                table: "CiudadanoConocimientoCompetenciaModel",
                newName: "IX_CiudadanoConocimientoCompetenciaModel_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoCargoInteres_CiudadanoId",
                table: "CiudadanoCargoInteresModel",
                newName: "IX_CiudadanoCargoInteresModel_CiudadanoId");

            migrationBuilder.AlterTable(
                name: "CiudadanoTipoNotificacionModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoInformacionLaboralModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoIdiomaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoHabilidadDestrezaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoExperienciaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoEducacionFormalModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoConocimientoCompetenciaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoCargoInteresModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoTipoNotificacionModel",
                table: "CiudadanoTipoNotificacionModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoInformacionLaboralModel",
                table: "CiudadanoInformacionLaboralModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoIdiomaModel",
                table: "CiudadanoIdiomaModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoHabilidadDestrezaModel",
                table: "CiudadanoHabilidadDestrezaModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoExperienciaModel",
                table: "CiudadanoExperienciaModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoEducacionFormalModel",
                table: "CiudadanoEducacionFormalModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoConocimientoCompetenciaModel",
                table: "CiudadanoConocimientoCompetenciaModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoCargoInteresModel",
                table: "CiudadanoCargoInteresModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoModel",
                table: "CiudadanoModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoCargoInteresModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoCargoInteresModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoConocimientoCompetenciaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoConocimientoCompetenciaModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoEducacionFormalModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoEducacionFormalModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoEducacionNoFormal_CiudadanoModel_CiudadanoId",
                table: "CiudadanoEducacionNoFormal",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoExperienciaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoExperienciaModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoHabilidadDestrezaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoHabilidadDestrezaModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoIdiomaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoIdiomaModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoInformacionLaboralModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoInformacionLaboralModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoRedesSociales_CiudadanoModel_CiudadanoId",
                table: "CiudadanoRedesSociales",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoTipoNotificacionModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoTipoNotificacionModel",
                column: "CiudadanoId",
                principalTable: "CiudadanoModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoCargoInteresModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoCargoInteresModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoConocimientoCompetenciaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoConocimientoCompetenciaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoEducacionFormalModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoEducacionFormalModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoEducacionNoFormal_CiudadanoModel_CiudadanoId",
                table: "CiudadanoEducacionNoFormal");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoExperienciaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoExperienciaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoHabilidadDestrezaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoHabilidadDestrezaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoIdiomaModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoIdiomaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoInformacionLaboralModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoInformacionLaboralModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoRedesSociales_CiudadanoModel_CiudadanoId",
                table: "CiudadanoRedesSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_CiudadanoTipoNotificacionModel_CiudadanoModel_CiudadanoId",
                table: "CiudadanoTipoNotificacionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoTipoNotificacionModel",
                table: "CiudadanoTipoNotificacionModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoModel",
                table: "CiudadanoModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoInformacionLaboralModel",
                table: "CiudadanoInformacionLaboralModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoIdiomaModel",
                table: "CiudadanoIdiomaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoHabilidadDestrezaModel",
                table: "CiudadanoHabilidadDestrezaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoExperienciaModel",
                table: "CiudadanoExperienciaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoEducacionFormalModel",
                table: "CiudadanoEducacionFormalModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoConocimientoCompetenciaModel",
                table: "CiudadanoConocimientoCompetenciaModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CiudadanoCargoInteresModel",
                table: "CiudadanoCargoInteresModel")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameTable(
                name: "CiudadanoTipoNotificacionModel",
                newName: "CiudadanoTipoNotificacion")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoModel",
                newName: "Ciudadano")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoInformacionLaboralModel",
                newName: "CiudadanoInformacionLaboral")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoIdiomaModel",
                newName: "CiudadanoIdioma")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoHabilidadDestrezaModel",
                newName: "CiudadanoHabilidadDestreza")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoExperienciaModel",
                newName: "CiudadanoExperiencia")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoEducacionFormalModel",
                newName: "CiudadanoEducacionFormal")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoConocimientoCompetenciaModel",
                newName: "CiudadanoConocimientoCompetencia")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameTable(
                name: "CiudadanoCargoInteresModel",
                newName: "CiudadanoCargoInteres")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresModelHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null);

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoTipoNotificacionModel_CiudadanoId",
                table: "CiudadanoTipoNotificacion",
                newName: "IX_CiudadanoTipoNotificacion_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoInformacionLaboralModel_CiudadanoId",
                table: "CiudadanoInformacionLaboral",
                newName: "IX_CiudadanoInformacionLaboral_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoIdiomaModel_CiudadanoId",
                table: "CiudadanoIdioma",
                newName: "IX_CiudadanoIdioma_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoHabilidadDestrezaModel_CiudadanoId",
                table: "CiudadanoHabilidadDestreza",
                newName: "IX_CiudadanoHabilidadDestreza_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoExperienciaModel_CiudadanoId",
                table: "CiudadanoExperiencia",
                newName: "IX_CiudadanoExperiencia_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoEducacionFormalModel_CiudadanoId",
                table: "CiudadanoEducacionFormal",
                newName: "IX_CiudadanoEducacionFormal_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoConocimientoCompetenciaModel_CiudadanoId",
                table: "CiudadanoConocimientoCompetencia",
                newName: "IX_CiudadanoConocimientoCompetencia_CiudadanoId");

            migrationBuilder.RenameIndex(
                name: "IX_CiudadanoCargoInteresModel_CiudadanoId",
                table: "CiudadanoCargoInteres",
                newName: "IX_CiudadanoCargoInteres_CiudadanoId");

            migrationBuilder.AlterTable(
                name: "CiudadanoTipoNotificacion")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoTipoNotificacionModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "Ciudadano")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoInformacionLaboral")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoInformacionLaboralModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoIdioma")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoIdiomaModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoHabilidadDestreza")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoHabilidadDestrezaModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoExperiencia")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoExperienciaModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoEducacionFormal")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoEducacionFormalModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoConocimientoCompetencia")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoConocimientoCompetenciaModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "CiudadanoCargoInteres")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "CiudadanoCargoInteresModelHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoTipoNotificacion",
                table: "CiudadanoTipoNotificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudadano",
                table: "Ciudadano",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoInformacionLaboral",
                table: "CiudadanoInformacionLaboral",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoIdioma",
                table: "CiudadanoIdioma",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoHabilidadDestreza",
                table: "CiudadanoHabilidadDestreza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoExperiencia",
                table: "CiudadanoExperiencia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoEducacionFormal",
                table: "CiudadanoEducacionFormal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoConocimientoCompetencia",
                table: "CiudadanoConocimientoCompetencia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CiudadanoCargoInteres",
                table: "CiudadanoCargoInteres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoCargoInteres_Ciudadano_CiudadanoId",
                table: "CiudadanoCargoInteres",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoConocimientoCompetencia_Ciudadano_CiudadanoId",
                table: "CiudadanoConocimientoCompetencia",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoEducacionFormal_Ciudadano_CiudadanoId",
                table: "CiudadanoEducacionFormal",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoEducacionNoFormal_Ciudadano_CiudadanoId",
                table: "CiudadanoEducacionNoFormal",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoExperiencia_Ciudadano_CiudadanoId",
                table: "CiudadanoExperiencia",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoHabilidadDestreza_Ciudadano_CiudadanoId",
                table: "CiudadanoHabilidadDestreza",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoIdioma_Ciudadano_CiudadanoId",
                table: "CiudadanoIdioma",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoInformacionLaboral_Ciudadano_CiudadanoId",
                table: "CiudadanoInformacionLaboral",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoRedesSociales_Ciudadano_CiudadanoId",
                table: "CiudadanoRedesSociales",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CiudadanoTipoNotificacion_Ciudadano_CiudadanoId",
                table: "CiudadanoTipoNotificacion",
                column: "CiudadanoId",
                principalTable: "Ciudadano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
