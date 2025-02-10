using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class fechas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "zonaGeografica");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "zonaGeografica");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tituloNivelEducativo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tituloNivelEducativo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tituloHomologado");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tituloHomologado");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoZonaGeografica");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoZonaGeografica");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoUbicacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoUbicacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoSituacionLaboral");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoSituacionLaboral");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoSalario");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoSalario");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoProyecto");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoProyecto");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoPrestador");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoPrestador");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoPoblacionVulnerable");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoPoblacionVulnerable");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoPoblacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoPoblacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoNotificacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoNotificacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoLibretaMilitar");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoLibretaMilitar");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoExperienciaPrevia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoExperienciaPrevia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoExperiencia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoExperiencia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoDocumento");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoDocumento");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoDireccion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoDireccion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoContrato");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoContrato");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "tipoCapacitacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "tipoCapacitacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "terminos");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "terminos");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "subSectorEconomico");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "subSectorEconomico");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "subCompetencia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "subCompetencia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "subaficion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "subaficion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "situacionActualTrabajo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "situacionActualTrabajo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "sectorEconomico");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "sectorEconomico");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "sector");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "sector");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "redSocial");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "redSocial");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "rangoSalarial");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "rangoSalarial");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "profesion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "profesion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "preguntaSeguridad");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "preguntaSeguridad");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "plantillaMensaje");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "plantillaMensaje");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "plantillaDescripcionVacante");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "plantillaDescripcionVacante");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "periodicidadSalarial");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "periodicidadSalarial");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "pais");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "pais");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "ocupacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "ocupacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "nucleoConocimientoHidrocarburos");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "nucleoConocimientoHidrocarburos");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "nucleoConocimiento");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "nucleoConocimiento");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "nivelEducativo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "nivelEducativo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "nivelDominioIdioma");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "nivelDominioIdioma");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "nivelCompetencia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "nivelCompetencia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "municipio");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "municipio");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "motivoRechazo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "motivoRechazo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "motivoExcepcionalidad");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "motivoExcepcionalidad");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "motivoCambioPrestador");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "motivoCambioPrestador");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "motivoAmpliarZona");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "motivoAmpliarZona");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "modalidadTrabajo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "modalidadTrabajo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "mensajePreseleccion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "mensajePreseleccion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "localidad");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "localidad");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "jornadaLaboral");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "jornadaLaboral");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "institucionNivelEducativo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "institucionNivelEducativo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "institucion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "institucion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "informacionLaboral");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "informacionLaboral");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "idioma");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "idioma");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "grupoEtnico");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "grupoEtnico");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "genero");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "genero");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "frecuenciaAficion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "frecuenciaAficion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "fluidezIdioma");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "fluidezIdioma");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "estadoVacante");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "estadoVacante");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "estadoEducacionNoFormal");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "estadoEducacionNoFormal");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "estadoEducacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "estadoEducacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "estadoCivil");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "estadoCivil");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "estadoCiudadano");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "estadoCiudadano");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "eps");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "eps");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "divisionTerritorial");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "divisionTerritorial");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "discapacidad");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "discapacidad");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "direccionTipoVia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "direccionTipoVia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "direccionLetra");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "direccionLetra");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "direccionCuadrante");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "direccionCuadrante");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "direccionComplemento");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "direccionComplemento");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "descripcionExperienciasPrevias");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "descripcionExperienciasPrevias");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "departamento");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "departamento");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "cursosComplementarios");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "cursosComplementarios");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCgrupoPrimario");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCgrupoPrimario");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCgranGrupo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCgranGrupo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCfuncion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCfuncion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCdestrezaOcupacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCdestrezaOcupacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCdestreza");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCdestreza");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCdenominacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCdenominacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCConocimientoOcupacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCConocimientoOcupacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "CUOCconocimiento");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CUOCconocimiento");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "criterioMatch");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "criterioMatch");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "condicionSaludMental");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "condicionSaludMental");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "comuna");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "comuna");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "competenciasDuras");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "competenciasDuras");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "claseAficion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "claseAficion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "categoriaLicencia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "categoriaLicencia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "cargo");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "cargo");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "areaInfluencia");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "areaInfluencia");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "areaEmpresa");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "areaEmpresa");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "areaConocimiento");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "areaConocimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "zonaGeografica",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "zonaGeografica",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tituloNivelEducativo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tituloNivelEducativo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tituloHomologado",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tituloHomologado",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoZonaGeografica",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoZonaGeografica",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoUbicacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoUbicacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoSituacionLaboral",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoSituacionLaboral",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoSalario",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoSalario",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoProyecto",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoProyecto",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoPrestador",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoPrestador",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoPoblacionVulnerable",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoPoblacionVulnerable",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoPoblacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoPoblacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoNotificacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoNotificacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoLibretaMilitar",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoLibretaMilitar",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoExperienciaPrevia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoExperienciaPrevia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoExperiencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoExperiencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoDocumento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoDocumento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoDireccion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoDireccion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoContrato",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoContrato",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "tipoCapacitacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "tipoCapacitacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "terminos",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "terminos",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "subSectorEconomico",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "subSectorEconomico",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "subCompetencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "subCompetencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "subaficion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "subaficion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "situacionActualTrabajo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "situacionActualTrabajo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "sectorEconomico",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "sectorEconomico",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "sector",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "sector",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "redSocial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "redSocial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "rangoSalarial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "rangoSalarial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "profesion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "profesion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "preguntaSeguridad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "preguntaSeguridad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "plantillaMensaje",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "plantillaMensaje",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "plantillaDescripcionVacante",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "plantillaDescripcionVacante",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "periodicidadSalarial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "periodicidadSalarial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "pais",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "pais",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "ocupacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "ocupacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "nucleoConocimientoHidrocarburos",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "nucleoConocimientoHidrocarburos",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "nucleoConocimiento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "nucleoConocimiento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "nivelEducativo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "nivelEducativo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "nivelDominioIdioma",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "nivelDominioIdioma",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "nivelCompetencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "nivelCompetencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "municipio",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "municipio",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "motivoRechazo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "motivoRechazo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "motivoExcepcionalidad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "motivoExcepcionalidad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "motivoCambioPrestador",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "motivoCambioPrestador",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "motivoAmpliarZona",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "motivoAmpliarZona",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "modalidadTrabajo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "modalidadTrabajo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "mensajePreseleccion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "mensajePreseleccion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "localidad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "localidad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "jornadaLaboral",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "jornadaLaboral",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "institucionNivelEducativo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "institucionNivelEducativo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "institucion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "institucion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "informacionLaboral",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "informacionLaboral",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "idioma",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "idioma",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "grupoEtnico",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "grupoEtnico",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "genero",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "genero",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "frecuenciaAficion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "frecuenciaAficion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "fluidezIdioma",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "fluidezIdioma",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "estadoVacante",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "estadoVacante",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "estadoEducacionNoFormal",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "estadoEducacionNoFormal",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "estadoEducacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "estadoEducacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "estadoCivil",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "estadoCivil",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "estadoCiudadano",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "estadoCiudadano",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "eps",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "eps",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "divisionTerritorial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "divisionTerritorial",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "discapacidad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "discapacidad",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "direccionTipoVia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "direccionTipoVia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "direccionLetra",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "direccionLetra",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "direccionCuadrante",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "direccionCuadrante",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "direccionComplemento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "direccionComplemento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "descripcionExperienciasPrevias",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "descripcionExperienciasPrevias",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "departamento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "departamento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "cursosComplementarios",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "cursosComplementarios",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCgrupoPrimario",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCgrupoPrimario",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCgranGrupo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCgranGrupo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCfuncion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCfuncion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCdestrezaOcupacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCdestrezaOcupacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCdestreza",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCdestreza",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCdenominacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCdenominacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCConocimientoOcupacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCConocimientoOcupacion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "CUOCconocimiento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "CUOCconocimiento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "criterioMatch",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "criterioMatch",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "condicionSaludMental",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "condicionSaludMental",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "comuna",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "comuna",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "competenciasDuras",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "competenciasDuras",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "claseAficion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "claseAficion",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "categoriaLicencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "categoriaLicencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "cargo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "cargo",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "areaInfluencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "areaInfluencia",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "areaEmpresa",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "areaEmpresa",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaCreacion",
                table: "areaConocimiento",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FechaModificacion",
                table: "areaConocimiento",
                type: "datetimeoffset",
                nullable: true);
        }
    }
}
