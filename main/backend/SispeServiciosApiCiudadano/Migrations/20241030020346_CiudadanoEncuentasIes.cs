using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class CiudadanoEncuentasIes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadanoEncuentasIes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexoId = table.Column<int>(type: "int", nullable: true),
                    EstadoCivilId = table.Column<int>(type: "int", nullable: true),
                    PaisResidenciaId = table.Column<int>(type: "int", nullable: true),
                    DepartamentoResidenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioResidenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgresadoId = table.Column<int>(type: "int", nullable: true),
                    Programa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicioPrograma = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinPrograma = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TiempoTranscurridoPrimerEmpleoId = table.Column<int>(type: "int", nullable: true),
                    EmpleosRelacionadoId = table.Column<int>(type: "int", nullable: true),
                    TieneEmpleoId = table.Column<int>(type: "int", nullable: true),
                    TrabajaPorCuentaPropiaId = table.Column<int>(type: "int", nullable: true),
                    TiempoTrabajoSemanalId = table.Column<int>(type: "int", nullable: true),
                    IngresoSalarialId = table.Column<int>(type: "int", nullable: true),
                    CambiarTrabajoActualId = table.Column<int>(type: "int", nullable: true),
                    MotivoCambioEmpleoId = table.Column<int>(type: "int", nullable: true),
                    OtroMotivoCambioEmpleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedioEmpleadoParaBusquedaEmepladoId = table.Column<int>(type: "int", nullable: true),
                    sectorEmpresaId = table.Column<int>(type: "int", nullable: true),
                    AntiguedadEmpleoId = table.Column<int>(type: "int", nullable: true),
                    TipoContratoId = table.Column<int>(type: "int", nullable: true),
                    JerarquiaEmeploId = table.Column<int>(type: "int", nullable: true),
                    SatisfechoConTrabajoActualId = table.Column<int>(type: "int", nullable: true),
                    SatisfechoConNumeroHorasTrabajadaId = table.Column<int>(type: "int", nullable: true),
                    SatisfechoConAplicacionConocimientosId = table.Column<int>(type: "int", nullable: true),
                    SatisfechoConRemuneracionId = table.Column<int>(type: "int", nullable: true),
                    SatisfechoConBeneficiosId = table.Column<int>(type: "int", nullable: true),
                    SatisfechoConJornadaLaboralId = table.Column<int>(type: "int", nullable: true),
                    SectorEconomicoId = table.Column<int>(type: "int", nullable: true),
                    ConsideracionTrabajoActualId = table.Column<int>(type: "int", nullable: true),
                    GradoRelacionProfesionEmpleoActualId = table.Column<int>(type: "int", nullable: true),
                    AreaTrabajoId = table.Column<int>(type: "int", nullable: true),
                    TamanioEmpresaId = table.Column<int>(type: "int", nullable: true),
                    RazonesTrabajoIndependienteId = table.Column<int>(type: "int", nullable: true),
                    FormaTrabajoRealizadoId = table.Column<int>(type: "int", nullable: true),
                    MotivoDesvinculacionUltimoEmpleoId = table.Column<int>(type: "int", nullable: true),
                    DisponibleParaTrabajar8SemanasId = table.Column<int>(type: "int", nullable: true),
                    DisponibleParaTrabajar12MesesId = table.Column<int>(type: "int", nullable: true),
                    FundamentacionTeoricaId = table.Column<int>(type: "int", nullable: true),
                    RelacionTeoriaPracticaId = table.Column<int>(type: "int", nullable: true),
                    DesarrolloHabilidadesInvestigacionId = table.Column<int>(type: "int", nullable: true),
                    FormacionIntegralId = table.Column<int>(type: "int", nullable: true),
                    RecomiendaElProgramaUniversidadId = table.Column<int>(type: "int", nullable: true),
                    RazonRecomendarProgramaId = table.Column<int>(type: "int", nullable: true),
                    ConoceAcreditacionUniversidadId = table.Column<int>(type: "int", nullable: true),
                    ConcervaRelacionConUniversidadId = table.Column<int>(type: "int", nullable: true),
                    AporteFormacionDesempenioLaboralId = table.Column<int>(type: "int", nullable: true),
                    EstudioPostgradoTerminadoId = table.Column<int>(type: "int", nullable: true),
                    NombrePostgrado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversidadPostgrado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealizandoEstudiosPostgradoId = table.Column<int>(type: "int", nullable: true),
                    NombrePostgradoEnCurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversidadPostgradoEnCurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacitacionRequeridaMejorarId = table.Column<int>(type: "int", nullable: true),
                    AreaCapacitacionRequeridaId = table.Column<int>(type: "int", nullable: true),
                    CapacitacionRequeridaMejorar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradoEscolariadPadreId = table.Column<int>(type: "int", nullable: true),
                    GradoEscolariadMadreId = table.Column<int>(type: "int", nullable: true),
                    TrabajoDuranteSuCarreraId = table.Column<int>(type: "int", nullable: true),
                    RazonTrabajoDuranteSuCarreraId = table.Column<int>(type: "int", nullable: true),
                    CuandoComenzoTrabajarId = table.Column<int>(type: "int", nullable: true),
                    EfectosTrabajoDuranteEstudiosId = table.Column<int>(type: "int", nullable: true),
                    OtrosEfectosTrabajoDuranteEstudios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoEncuentasIes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoEncuentasIes");
        }
    }
}
