using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServicios.Api.Intermediacion.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VacanteEstados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteEstados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacante",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Indicador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuestosRequeridos = table.Column<int>(type: "int", nullable: true),
                    ModalidadTrabajoId = table.Column<int>(type: "int", nullable: true),
                    UbicacionId = table.Column<int>(type: "int", nullable: true),
                    SectorEconomicoId = table.Column<int>(type: "int", nullable: true),
                    SubsectorEconomicoId = table.Column<int>(type: "int", nullable: true),
                    RequiereViajarPorTrabajo = table.Column<bool>(type: "bit", nullable: true),
                    TendraPersonasCargo = table.Column<bool>(type: "bit", nullable: true),
                    RequiereLicenciaConduccion = table.Column<bool>(type: "bit", nullable: true),
                    CategoriaLicenciaCarroId = table.Column<int>(type: "int", nullable: true),
                    RequiereLicenciaConduccionMoto = table.Column<bool>(type: "bit", nullable: true),
                    CategoriaLicenciaMotoId = table.Column<int>(type: "int", nullable: true),
                    AreaEmpresaId = table.Column<int>(type: "int", nullable: true),
                    ResponsableId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaEstimadaOcupacionCargo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaVencimientoVacante = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaLimiteEnvioHv = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Confidencial = table.Column<bool>(type: "bit", nullable: true),
                    SolicitudExcepcionalidad = table.Column<bool>(type: "bit", nullable: true),
                    SolicitudAutorizacionExcepcionalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AptaParaPersonasConDiscapacidad = table.Column<bool>(type: "bit", nullable: true),
                    GestionadaPorPrestador = table.Column<bool>(type: "bit", nullable: true),
                    GetionadaPorPrestadorAlterno = table.Column<bool>(type: "bit", nullable: true),
                    FormacionTitulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Graduado = table.Column<bool>(type: "bit", nullable: true),
                    NivelMinimoEstudioId = table.Column<int>(type: "int", nullable: true),
                    RequiereExperienciaGeneral = table.Column<bool>(type: "bit", nullable: true),
                    TiempoExperiencia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RequiereExperienciaEspecifica = table.Column<bool>(type: "bit", nullable: true),
                    DescripcionExperienciaEspecifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiereCapacitacionEspecifica = table.Column<bool>(type: "bit", nullable: true),
                    DescripcionCapacitacionEspecifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiereCertificacionEspecifica = table.Column<bool>(type: "bit", nullable: true),
                    DescripcionCertificacionEspecifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformacionAdicional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoContratoId = table.Column<int>(type: "int", nullable: true),
                    JornadaLaboralId = table.Column<int>(type: "int", nullable: true),
                    RangoInicailId = table.Column<int>(type: "int", nullable: true),
                    RangoFinalId = table.Column<int>(type: "int", nullable: true),
                    PeriodicidadSalarialId = table.Column<int>(type: "int", nullable: true),
                    VisibilidadSalario = table.Column<bool>(type: "bit", nullable: true),
                    CompensacionAdicional = table.Column<bool>(type: "bit", nullable: true),
                    DescripcionCompensacionAdicional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacante_VacanteEstados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "VacanteEstados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VacanteConocimientosCompetencias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConocimientoCompetenciaId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteConocimientosCompetencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacanteConocimientosCompetencias_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacanteDiscapacidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscapacidadId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteDiscapacidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacanteDiscapacidades_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacanteHabilidadesdDestrezas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabilidadDestrezaId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteHabilidadesdDestrezas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacanteHabilidadesdDestrezas_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacanteIdioma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdiomaId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Conversacional = table.Column<int>(type: "int", nullable: false),
                    Lectura = table.Column<int>(type: "int", nullable: false),
                    Escritura = table.Column<int>(type: "int", nullable: false),
                    Escucha = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteIdioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacanteIdioma_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacanteOcupacionRelacionada",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OcupacionesRelacionadoId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacanteOcupacionRelacionada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacanteOcupacionRelacionada_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacantePrestadorAlterno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrestadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacantePrestadorAlterno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacantePrestadorAlterno_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacantesMotivosExepcionalidad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotivosExepcionalidadId = table.Column<int>(type: "int", nullable: false),
                    VacanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacantesMotivosExepcionalidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacantesMotivosExepcionalidad_Vacante_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "Vacante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacante_EstadoId",
                table: "Vacante",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_VacanteConocimientosCompetencias_VacanteId",
                table: "VacanteConocimientosCompetencias",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacanteDiscapacidades_VacanteId",
                table: "VacanteDiscapacidades",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacanteHabilidadesdDestrezas_VacanteId",
                table: "VacanteHabilidadesdDestrezas",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacanteIdioma_VacanteId",
                table: "VacanteIdioma",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacanteOcupacionRelacionada_VacanteId",
                table: "VacanteOcupacionRelacionada",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacantePrestadorAlterno_VacanteId",
                table: "VacantePrestadorAlterno",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacantesMotivosExepcionalidad_VacanteId",
                table: "VacantesMotivosExepcionalidad",
                column: "VacanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VacanteConocimientosCompetencias");

            migrationBuilder.DropTable(
                name: "VacanteDiscapacidades");

            migrationBuilder.DropTable(
                name: "VacanteHabilidadesdDestrezas");

            migrationBuilder.DropTable(
                name: "VacanteIdioma");

            migrationBuilder.DropTable(
                name: "VacanteOcupacionRelacionada");

            migrationBuilder.DropTable(
                name: "VacantePrestadorAlterno");

            migrationBuilder.DropTable(
                name: "VacantesMotivosExepcionalidad");

            migrationBuilder.DropTable(
                name: "Vacante");

            migrationBuilder.DropTable(
                name: "VacanteEstados");
        }
    }
}
