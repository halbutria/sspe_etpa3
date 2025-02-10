using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiCiudadano.Migrations
{
    public partial class RefactorInitAllMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "People");

            migrationBuilder.CreateTable(
                name: "CiudadanoPersona",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SexoId = table.Column<int>(type: "int", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisResidenciaId = table.Column<int>(type: "int", nullable: true),
                    DepartamentoResidenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioResidenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrestadorPreferenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuntoAtencionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreguntaSeguridadId = table.Column<int>(type: "int", nullable: true),
                    PreguntaSeguridadRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminosCondiciones = table.Column<bool>(type: "bit", nullable: false),
                    LocalidadComunaId = table.Column<int>(type: "int", nullable: true),
                    PreguntaLibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    BarrioResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerteneceARural = table.Column<bool>(type: "bit", nullable: false),
                    OtroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaExpedicionDocumento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DireccionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalLetraId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalLetraNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalBisId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalBisNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalSegundaLetraId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalSegundaLetraNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalCuadranteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalCuadranteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignoNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradoraLetraId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneralLetraNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradoraPlaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradoraCuadranteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradoraCuadranteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoPersona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                schema: "People",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TipoPersona = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplementoDireccion",
                schema: "People",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdComplemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreComplemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplementoDireccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionAvanceHojaVida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionAvanceHojaVida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelEducativo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    RegistraInstitucion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelEducativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudadano",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SexoId = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionResidencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisResidenciaId = table.Column<int>(type: "int", nullable: false),
                    DepartamentoResidenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioResidenciaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrestadorPreferenciaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuntoAtencionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreguntaSeguridadId = table.Column<int>(type: "int", nullable: true),
                    PreguntaSeguridadRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminosCondiciones = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoDatosPersonales = table.Column<bool>(type: "bit", nullable: false),
                    PorcentajeRegistro = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PorcentajeHv = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PorcentajeInfoPersonal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PorcentajeEduFormal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PorcentajeInfoLaboral = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PorcentajeEduNoFormal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LocalidadComunaId = table.Column<int>(type: "int", nullable: true),
                    GeneroId = table.Column<int>(type: "int", nullable: true),
                    CualGenero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrientacionSexualId = table.Column<int>(type: "int", nullable: true),
                    CualOrientacionSexual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreguntaLibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispuestoDesplazarseDiariamente = table.Column<bool>(type: "bit", nullable: true),
                    DispuestoCambiarMunicipio = table.Column<bool>(type: "bit", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    EstadoCivilId = table.Column<int>(type: "int", nullable: true),
                    PaisNacimientoId = table.Column<int>(type: "int", nullable: true),
                    TieneLibretaMilitar = table.Column<bool>(type: "bit", nullable: true),
                    TipoLibretaMilitarId = table.Column<int>(type: "int", nullable: true),
                    NumeroLibretaMiltar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentoNacimientoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioNacimientoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NacionalidadId = table.Column<int>(type: "int", nullable: true),
                    JefeHogar = table.Column<bool>(type: "bit", nullable: true),
                    PoblacionFocalizada = table.Column<bool>(type: "bit", nullable: true),
                    Sisben = table.Column<bool>(type: "bit", nullable: true),
                    EpsId = table.Column<int>(type: "int", nullable: true),
                    BarrioResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerteneceARural = table.Column<bool>(type: "bit", nullable: true),
                    OtroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RangoSalarialId = table.Column<int>(type: "int", nullable: true),
                    Estrato = table.Column<int>(type: "int", nullable: true),
                    PerfilLaboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosibilidadViajar = table.Column<bool>(type: "bit", nullable: true),
                    PosibilidadTrasladarse = table.Column<bool>(type: "bit", nullable: true),
                    InteresOfertasTeletrabajo = table.Column<bool>(type: "bit", nullable: true),
                    SituacionLaboralActualId = table.Column<int>(type: "int", nullable: true),
                    PropiedadMedioTransporte = table.Column<bool>(type: "bit", nullable: true),
                    TieneLicenciaConduccionCarro = table.Column<bool>(type: "bit", nullable: true),
                    CategoriaLicenciaCarroId = table.Column<int>(type: "int", nullable: true),
                    TieneLicenciaConduccionMoto = table.Column<bool>(type: "bit", nullable: true),
                    CategoriaLicenciaMotoId = table.Column<int>(type: "int", nullable: true),
                    TieneEducacionFormal = table.Column<bool>(type: "bit", nullable: true),
                    InteresPracticaEmpresarial = table.Column<bool>(type: "bit", nullable: true),
                    TieneInformacionLaboral = table.Column<bool>(type: "bit", nullable: true),
                    TieneEducacionNoFormal = table.Column<bool>(type: "bit", nullable: true),
                    TieneExperienciaLaboral = table.Column<bool>(type: "bit", nullable: true),
                    TipoDocumentoAdicionalId = table.Column<int>(type: "int", nullable: true),
                    NumeroDocumentoAdicional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autorregistro = table.Column<bool>(type: "bit", nullable: true),
                    HojaVidaCompleta = table.Column<bool>(type: "bit", nullable: true),
                    EstadoCiudadanoId = table.Column<int>(type: "int", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    FechaTerminosCondiciones = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaTratamientoDatos = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaExpedicionDocumento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoResidencia = table.Column<bool>(type: "bit", nullable: true),
                    EstadoNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiudadNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudadano", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudadano_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ciudadano_Pais_NacionalidadId",
                        column: x => x.NacionalidadId,
                        principalTable: "Pais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ciudadano_Pais_PaisResidenciaId",
                        column: x => x.PaisResidenciaId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoCargoInteres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoInteresId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoIntertesAnteriorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoCargoInteres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoCargoInteres_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoCondicionMental",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CondicionMentalId = table.Column<int>(type: "int", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoCondicionMental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoCondicionMental_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoConocimientoCompetencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConocimientoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoConocimientoCompetencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoConocimientoCompetencia_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoDireccion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ViaPrincipalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalLetraId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalLetraNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalBisId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalBisNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalSegundaLetraId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalSegundaLetraNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalCuadranteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaPrincipalCuadranteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradora = table.Column<int>(type: "int", nullable: true),
                    ViaGeneradoraLetraId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneralLetraNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradoraPlaca = table.Column<int>(type: "int", nullable: true),
                    ViaGeneradoraCuadranteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaGeneradoraCuadranteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoDireccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoDireccion_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoDiscapacidad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisacapacidaId = table.Column<int>(type: "int", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoDiscapacidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoDiscapacidad_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoEducacionFormal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NucleoConocimientoId = table.Column<int>(type: "int", nullable: true),
                    NivelEducativoId = table.Column<int>(type: "int", nullable: false),
                    AreaConocimientoId = table.Column<int>(type: "int", nullable: true),
                    TituloObtenido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TituloHomologadoId = table.Column<int>(type: "int", nullable: true),
                    Institucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstitucionId = table.Column<int>(type: "int", nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TarjetaProfesional = table.Column<bool>(type: "bit", nullable: true),
                    NumeroTarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaExpedicionTarjetaProfesional = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PracticaEmpresarial = table.Column<bool>(type: "bit", nullable: false),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoEducacionFormal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoEducacionFormal_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CiudadanoEducacionFormal_NivelEducativo_NivelEducativoId",
                        column: x => x.NivelEducativoId,
                        principalTable: "NivelEducativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoEducacionNoFormal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoCertificadoCapacitacionId = table.Column<int>(type: "int", nullable: false),
                    NombrePrograma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Institucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: true),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    FechaCertificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoEducacionNoFormal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoEducacionNoFormal_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoExperiencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoExperienciaId = table.Column<int>(type: "int", nullable: false),
                    OcupacionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LugarExperiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRetiro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoExperiencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoExperiencia_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoGrupoEtnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoEtnicoId = table.Column<int>(type: "int", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoGrupoEtnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoGrupoEtnico_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoHabilidadDestreza",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabilidadId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoHabilidadDestreza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoHabilidadDestreza_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoIdioma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdiomaId = table.Column<int>(type: "int", nullable: false),
                    NivelEscrito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelHablado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelEscucha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelLectura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoIdioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoIdioma_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoInformacionLaboral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoExperienciaId = table.Column<int>(type: "int", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRetiro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrabajoActual = table.Column<bool>(type: "bit", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    TelefonoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    Funciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OcupacionEquivalenteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductoServicioProduceComercializa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuantasPresonasTrabajanConUsted = table.Column<int>(type: "int", nullable: true),
                    OcupacionEquivalenteAnteriorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoInformacionLaboral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoInformacionLaboral_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoRedesSociales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RedSocialId = table.Column<int>(type: "int", nullable: false),
                    NombreRedSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreUsuarioRedSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoRedesSociales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoRedesSociales_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoTipoNotificacion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipoNotificacionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoTipoNotificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoTipoNotificacion_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoTipoPoblacion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoPoblacionId = table.Column<int>(type: "int", nullable: false),
                    CiudadanoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCarga = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoTipoPoblacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoTipoPoblacion_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoDireccionComplemento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplementoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplementoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiudadanoDireccionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoDireccionComplemento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoDireccionComplemento_CiudadanoDireccion_CiudadanoDireccionId",
                        column: x => x.CiudadanoDireccionId,
                        principalTable: "CiudadanoDireccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoConocimientoCompetenciaExperienciaPrevia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoExperienciaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConocimientoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoConocimientoCompetenciaExperienciaPrevia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoConocimientoCompetenciaExperienciaPrevia_CiudadanoExperiencia_CiudadanoExperienciaId",
                        column: x => x.CiudadanoExperienciaId,
                        principalTable: "CiudadanoExperiencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoEducacionFormalExperiencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoExperienciaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiudadanoEducacionFormalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoEducacionFormalExperiencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoEducacionFormalExperiencia_CiudadanoEducacionFormal_CiudadanoEducacionFormalId",
                        column: x => x.CiudadanoEducacionFormalId,
                        principalTable: "CiudadanoEducacionFormal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CiudadanoEducacionFormalExperiencia_CiudadanoExperiencia_CiudadanoExperienciaId",
                        column: x => x.CiudadanoExperienciaId,
                        principalTable: "CiudadanoExperiencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoHabilidadDestrezaExperienciaPrevia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExperienciapreviaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabilidadId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoHabilidadDestrezaExperienciaPrevia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoHabilidadDestrezaExperienciaPrevia_CiudadanoExperiencia_ExperienciapreviaId",
                        column: x => x.ExperienciapreviaId,
                        principalTable: "CiudadanoExperiencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoConocimientoCompetenciaInformacionLaboral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InformacionLaboralId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConocimientoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoConocimientoCompetenciaInformacionLaboral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoConocimientoCompetenciaInformacionLaboral_CiudadanoInformacionLaboral_InformacionLaboralId",
                        column: x => x.InformacionLaboralId,
                        principalTable: "CiudadanoInformacionLaboral",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadanoHabilidadDestrezaInformacionLaboral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InformacionLaboralId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabilidadId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadanoHabilidadDestrezaInformacionLaboral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiudadanoHabilidadDestrezaInformacionLaboral_CiudadanoInformacionLaboral_InformacionLaboralId",
                        column: x => x.InformacionLaboralId,
                        principalTable: "CiudadanoInformacionLaboral",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_CorreoElectronico",
                table: "Ciudadano",
                column: "CorreoElectronico");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_Eliminado",
                table: "Ciudadano",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_FechaCreacion",
                table: "Ciudadano",
                column: "FechaCreacion");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_GeneroId",
                table: "Ciudadano",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_NacionalidadId",
                table: "Ciudadano",
                column: "NacionalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_NumeroDocumento",
                table: "Ciudadano",
                column: "NumeroDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_PaisResidenciaId",
                table: "Ciudadano",
                column: "PaisResidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_PrimerApellido",
                table: "Ciudadano",
                column: "PrimerApellido");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_PrimerNombre",
                table: "Ciudadano",
                column: "PrimerNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_SegundoApellido",
                table: "Ciudadano",
                column: "SegundoApellido");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_SegundoNombre",
                table: "Ciudadano",
                column: "SegundoNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadano_TipoDocumentoId",
                table: "Ciudadano",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoCargoInteres_CiudadanoId",
                table: "CiudadanoCargoInteres",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoCargoInteres_Eliminado",
                table: "CiudadanoCargoInteres",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoCondicionMental_CiudadanoId",
                table: "CiudadanoCondicionMental",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoCondicionMental_Eliminado",
                table: "CiudadanoCondicionMental",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoConocimientoCompetencia_CiudadanoId",
                table: "CiudadanoConocimientoCompetencia",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoConocimientoCompetencia_Eliminado",
                table: "CiudadanoConocimientoCompetencia",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoConocimientoCompetenciaExperienciaPrevia_CiudadanoExperienciaId",
                table: "CiudadanoConocimientoCompetenciaExperienciaPrevia",
                column: "CiudadanoExperienciaId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoConocimientoCompetenciaExperienciaPrevia_Eliminado",
                table: "CiudadanoConocimientoCompetenciaExperienciaPrevia",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoConocimientoCompetenciaInformacionLaboral_Eliminado",
                table: "CiudadanoConocimientoCompetenciaInformacionLaboral",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoConocimientoCompetenciaInformacionLaboral_InformacionLaboralId",
                table: "CiudadanoConocimientoCompetenciaInformacionLaboral",
                column: "InformacionLaboralId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoDireccion_CiudadanoId",
                table: "CiudadanoDireccion",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoDireccion_Eliminado",
                table: "CiudadanoDireccion",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoDireccionComplemento_CiudadanoDireccionId",
                table: "CiudadanoDireccionComplemento",
                column: "CiudadanoDireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoDireccionComplemento_Eliminado",
                table: "CiudadanoDireccionComplemento",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoDiscapacidad_CiudadanoId",
                table: "CiudadanoDiscapacidad",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoDiscapacidad_Eliminado",
                table: "CiudadanoDiscapacidad",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionFormal_CiudadanoId",
                table: "CiudadanoEducacionFormal",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionFormal_Eliminado",
                table: "CiudadanoEducacionFormal",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionFormal_NivelEducativoId",
                table: "CiudadanoEducacionFormal",
                column: "NivelEducativoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionFormalExperiencia_CiudadanoEducacionFormalId",
                table: "CiudadanoEducacionFormalExperiencia",
                column: "CiudadanoEducacionFormalId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionFormalExperiencia_CiudadanoExperienciaId",
                table: "CiudadanoEducacionFormalExperiencia",
                column: "CiudadanoExperienciaId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionFormalExperiencia_Eliminado",
                table: "CiudadanoEducacionFormalExperiencia",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionNoFormal_CiudadanoId",
                table: "CiudadanoEducacionNoFormal",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoEducacionNoFormal_Eliminado",
                table: "CiudadanoEducacionNoFormal",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoExperiencia_CiudadanoId",
                table: "CiudadanoExperiencia",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoExperiencia_Eliminado",
                table: "CiudadanoExperiencia",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoGrupoEtnico_CiudadanoId",
                table: "CiudadanoGrupoEtnico",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoGrupoEtnico_Eliminado",
                table: "CiudadanoGrupoEtnico",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoHabilidadDestreza_CiudadanoId",
                table: "CiudadanoHabilidadDestreza",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoHabilidadDestreza_Eliminado",
                table: "CiudadanoHabilidadDestreza",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoHabilidadDestrezaExperienciaPrevia_Eliminado",
                table: "CiudadanoHabilidadDestrezaExperienciaPrevia",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoHabilidadDestrezaExperienciaPrevia_ExperienciapreviaId",
                table: "CiudadanoHabilidadDestrezaExperienciaPrevia",
                column: "ExperienciapreviaId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoHabilidadDestrezaInformacionLaboral_Eliminado",
                table: "CiudadanoHabilidadDestrezaInformacionLaboral",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoHabilidadDestrezaInformacionLaboral_InformacionLaboralId",
                table: "CiudadanoHabilidadDestrezaInformacionLaboral",
                column: "InformacionLaboralId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoIdioma_CiudadanoId",
                table: "CiudadanoIdioma",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoIdioma_Eliminado",
                table: "CiudadanoIdioma",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoInformacionLaboral_CiudadanoId",
                table: "CiudadanoInformacionLaboral",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoInformacionLaboral_Eliminado",
                table: "CiudadanoInformacionLaboral",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoRedesSociales_CiudadanoId",
                table: "CiudadanoRedesSociales",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoRedesSociales_Eliminado",
                table: "CiudadanoRedesSociales",
                column: "Eliminado");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoTipoNotificacion_CiudadanoId",
                table: "CiudadanoTipoNotificacion",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoTipoPoblacion_CiudadanoId",
                table: "CiudadanoTipoPoblacion",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_CiudadanoTipoPoblacion_Eliminado",
                table: "CiudadanoTipoPoblacion",
                column: "Eliminado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiudadanoCargoInteres");

            migrationBuilder.DropTable(
                name: "CiudadanoCondicionMental");

            migrationBuilder.DropTable(
                name: "CiudadanoConocimientoCompetencia");

            migrationBuilder.DropTable(
                name: "CiudadanoConocimientoCompetenciaExperienciaPrevia");

            migrationBuilder.DropTable(
                name: "CiudadanoConocimientoCompetenciaInformacionLaboral");

            migrationBuilder.DropTable(
                name: "CiudadanoDireccionComplemento");

            migrationBuilder.DropTable(
                name: "CiudadanoDiscapacidad");

            migrationBuilder.DropTable(
                name: "CiudadanoEducacionFormalExperiencia");

            migrationBuilder.DropTable(
                name: "CiudadanoEducacionNoFormal");

            migrationBuilder.DropTable(
                name: "CiudadanoGrupoEtnico");

            migrationBuilder.DropTable(
                name: "CiudadanoHabilidadDestreza");

            migrationBuilder.DropTable(
                name: "CiudadanoHabilidadDestrezaExperienciaPrevia");

            migrationBuilder.DropTable(
                name: "CiudadanoHabilidadDestrezaInformacionLaboral");

            migrationBuilder.DropTable(
                name: "CiudadanoIdioma");

            migrationBuilder.DropTable(
                name: "CiudadanoPersona");

            migrationBuilder.DropTable(
                name: "CiudadanoRedesSociales");

            migrationBuilder.DropTable(
                name: "CiudadanoTipoNotificacion");

            migrationBuilder.DropTable(
                name: "CiudadanoTipoPoblacion");

            migrationBuilder.DropTable(
                name: "Cliente",
                schema: "People");

            migrationBuilder.DropTable(
                name: "ComplementoDireccion",
                schema: "People");

            migrationBuilder.DropTable(
                name: "ConfiguracionAvanceHojaVida");

            migrationBuilder.DropTable(
                name: "CiudadanoDireccion");

            migrationBuilder.DropTable(
                name: "CiudadanoEducacionFormal");

            migrationBuilder.DropTable(
                name: "CiudadanoExperiencia");

            migrationBuilder.DropTable(
                name: "CiudadanoInformacionLaboral");

            migrationBuilder.DropTable(
                name: "NivelEducativo");

            migrationBuilder.DropTable(
                name: "Ciudadano");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
