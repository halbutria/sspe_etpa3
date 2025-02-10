using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServicios.Api.Parametrico.Aplicacion
{
    public class Lista
    {
        public class ListaParametrico : IRequest<List<ParametricoDTO>>
        {
            public string? tipo { get; set; }
            public string? departamentoID { get; set; }
            public string? competenciaDuraID { get; set; }
            public string? claseAficionID { get; set; }
            public string? municipioID { get; set; }
            public string? codigo { get; set; }
            public string? prestadorID { get; set; }
            public int? sectorEconomicoId { get; set; }
            public string? DestrezaId { get; set; }
            public string? ConocimientoId { get; set; }
            public string? OcupacionId { get; set; }
            public string? ServiciosAsociadosId { get; set; }
            public string? ServiciosBasicosId { get; set; }
            public string? ServiciosOfertaId { get; set; }
        }


        public class Manejador : IRequestHandler<ListaParametrico, List<ParametricoDTO>>
        {
            private readonly Contexto _contexto;
            private readonly ContextoCiudadano _contextoCiudadano;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper, ContextoCiudadano contextoCiudadano)
            {
                _contexto = contexto;
                _mapper = mapper;
                _contextoCiudadano = contextoCiudadano;
            }

            public async Task<List<ParametricoDTO>> Handle(ListaParametrico request, CancellationToken cancellationToken)
            {
                List<ParametricoDTO> outPut = new List<ParametricoDTO>();
                switch (request.tipo)
                {
                    case "TipoDocumento":
                        var tipoDocumentos = await _contexto.tipoDocumento.ToListAsync();
                        outPut = _mapper.Map<List<Modelo.TipoDocumento>, List<ParametricoDTO>>(tipoDocumentos);
                        break;
                    case "Departamento":
                        var departamentos = await _contexto.departamento.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<Departamento>, List<ParametricoDTO>>(departamentos);
                        break;
                    case "Municipio":
                        var municipios = await _contexto.municipio.OrderBy(z => z.Nombre).ToListAsync();
                        if (request.departamentoID != "0" && !string.IsNullOrEmpty(request.departamentoID))
                        {
                            municipios = await _contexto.municipio.Where(x => x.DepartamentoId == request.departamentoID).OrderBy(z => z.Nombre).ToListAsync();
                        }
                        outPut = _mapper.Map<List<Municipio>, List<ParametricoDTO>>(municipios);
                        break;
                    case "TipoDireccion":
                        var tipoDirecciones = await _contexto.tipoDireccion.ToListAsync();
                        outPut = _mapper.Map<List<TipoDireccion>, List<ParametricoDTO>>(tipoDirecciones);
                        break;
                    case "TipoCursoComplementario":
                        var tipoCursoComplementario = await _contexto.tipoCapacitacion.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<TipoCapacitacion>, List<ParametricoDTO>>(tipoCursoComplementario);
                        break;
                    case "TipoUbicacion":
                        var tipoUbicacion = await _contexto.tipoUbicacion.ToListAsync();
                        outPut = _mapper.Map<List<TipoUbicacion>, List<ParametricoDTO>>(tipoUbicacion);
                        break;
                    case "NivelEducativo":
                        var nivelEducativo = await _contexto.nivelEducativo.OrderBy(z => z.Orden).ToListAsync();
                        outPut = _mapper.Map<List<NivelEducativo>, List<ParametricoDTO>>(nivelEducativo);
                        break;
                    case "Genero":
                        var genero = await _contexto.genero.ToListAsync();
                        outPut = _mapper.Map<List<Genero>, List<ParametricoDTO>>(genero);
                        break;
                    case "EstadoCivil":
                        var estadoCivil = await _contexto.estadoCivil.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<EstadoCivil>, List<ParametricoDTO>>(estadoCivil);
                        break;
                    case "GrupoEtnico":
                        var grupoEtnico = await _contexto.grupoEtnico.ToListAsync();
                        outPut = _mapper.Map<List<GrupoEtnico>, List<ParametricoDTO>>(grupoEtnico);
                        break;
                    case "TipoSituacionLaboral":
                        var tipoSituacionLaboral = await _contexto.tipoSituacionLaboral.ToListAsync();
                        outPut = _mapper.Map<List<TipoSituacionLaboral>, List<ParametricoDTO>>(tipoSituacionLaboral);
                        break;
                    case "NucleoConocimiento":
                        var nucleoConocimiento = await _contexto.nucleoConocimiento.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<NucleoConocimiento>, List<ParametricoDTO>>(nucleoConocimiento);
                        break;
                    case "TituloNivelEducativo":
                        var tituloNivelEducativo = await _contexto.tituloNivelEducativo.ToListAsync();
                        outPut = _mapper.Map<List<TituloNivelEducativo>, List<ParametricoDTO>>(tituloNivelEducativo);
                        break;
                    case "CursosComplementarios":
                        var cursosComplementarios = await _contexto.cursosComplementarios.ToListAsync();
                        outPut = _mapper.Map<List<CursosComplementarios>, List<ParametricoDTO>>(cursosComplementarios);
                        break;
                    case "NivelCompetencia":
                        var nivelCompetencia = await _contexto.nivelCompetencia.ToListAsync();
                        outPut = _mapper.Map<List<NivelCompetencia>, List<ParametricoDTO>>(nivelCompetencia);
                        break;
                    case "CompetenciasDuras":
                        var competenciasDuras = await _contexto.competenciasDuras.ToListAsync();
                        outPut = _mapper.Map<List<CompetenciasDuras>, List<ParametricoDTO>>(competenciasDuras);
                        break;
                    /*case "SubCompetencia":
                        var subcompetencia = await _contexto.subCompetencia.Where(x => x.CompetenciaDuraId == request.competenciaDuraID).ToListAsync();
                        outPut = _mapper.Map<List<Subcompetencia>, List<ParametricoDTO>>(subcompetencia);
                        break;*/
                    case "Sector":
                        var sector = await _contexto.sector.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<Sector>, List<ParametricoDTO>>(sector);
                        break;
                    case "Cargo":
                        var cargo = await _contexto.cargo.ToListAsync();
                        outPut = _mapper.Map<List<Cargo>, List<ParametricoDTO>>(cargo);
                        break;
                    case "TipoExperiencia":
                        var tipoExperiencia = await _contexto.tipoExperiencia.ToListAsync();
                        outPut = _mapper.Map<List<TipoExperiencia>, List<ParametricoDTO>>(tipoExperiencia);
                        break;
                    case "ClaseAficion":
                        var claseAficion = await _contexto.claseAficion.ToListAsync();
                        outPut = _mapper.Map<List<ClaseAficion>, List<ParametricoDTO>>(claseAficion);
                        break;
                    case "FrecuenciaAficion":
                        var frecuenciaAficion = await _contexto.frecuenciaAficion.ToListAsync();
                        outPut = _mapper.Map<List<FrecuenciaAficion>, List<ParametricoDTO>>(frecuenciaAficion);
                        break;
                    /*case "SubAficion":
                        var subaficion = await _contexto.subaficion.Where(x => x.ClaseAficionId == request.claseAficionID).ToListAsync();
                        outPut = _mapper.Map<List<Subaficion>, List<ParametricoDTO>>(subaficion);
                        break;*/
                    case "Pais":
                        var pais = await _contexto.pais.OrderBy(z => z.Nombre).ToListAsync();

                        outPut = _mapper.Map<List<Pais>, List<ParametricoDTO>>(pais);
                        break;
                    case "TipoNotificacion":
                        var tipoNotificacion = await _contexto.tipoNotificacion.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<TipoNotificacion>, List<ParametricoDTO>>(tipoNotificacion);
                        break;
                    case "PreguntaSeguridad":
                        var preguntaSeguridad = await _contexto.preguntaSeguridad.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<PreguntaSeguridad>, List<ParametricoDTO>>(preguntaSeguridad);
                        break;

                    case "Eps":
                        var eps = await _contexto.eps.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<Eps>, List<ParametricoDTO>>(eps);
                        break;
                    case "CategoriaLicencia":
                        var categoriaLicencia = await _contexto.categoriaLicencia.ToListAsync();
                        outPut = _mapper.Map<List<CategoriaLicencia>, List<ParametricoDTO>>(categoriaLicencia);
                        break;
                    case "RangoSalarial":
                        var rangoSalarial = await _contexto.rangoSalarial.ToListAsync();
                        outPut = _mapper.Map<List<RangoSalarial>, List<ParametricoDTO>>(rangoSalarial);
                        break;
                    case "Ocupacion":
                        var ocupacion = await _contexto.ocupacion.ToListAsync();
                        outPut = _mapper.Map<List<Ocupacion>, List<ParametricoDTO>>(ocupacion);
                        break;
                    case "EstadoEducacion":
                        var estadoEducacion = await _contexto.estadoEducacion.ToListAsync();
                        outPut = _mapper.Map<List<EstadoEducacion>, List<ParametricoDTO>>(estadoEducacion);
                        break;
                    case "Idioma":
                        var idioma = await _contexto.idioma.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<Idioma>, List<ParametricoDTO>>(idioma);
                        break;
                    case "NivelDominioIdioma":
                        var nivelDominacionIdioma = await _contexto.nivelDominioIdioma.ToListAsync();
                        outPut = _mapper.Map<List<NivelDominioIdioma>, List<ParametricoDTO>>(nivelDominacionIdioma);
                        break;
                    case "SectorEconomico":
                        var sectorEconomico = await _contexto.sectorEconomico.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<SectorEconomico>, List<ParametricoDTO>>(sectorEconomico);
                        break;


                    case "SubsectorEconomico":
                        var subsector = await _contexto.subSectorEconomico.OrderBy(z => z.Nombre).ToListAsync();
                        if (request.sectorEconomicoId != 0)
                            subsector = await _contexto.subSectorEconomico.Where(x => x.SectorEconomicoId == request.sectorEconomicoId).OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<SubsectorEconomico>, List<ParametricoDTO>>(subsector);
                        break;

                    case "SubsectorEconomico2":
                        var subsectorall = await _contexto.subSectorEconomico.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<SubsectorEconomico>, List<ParametricoDTO>>(subsectorall);
                        break;


                    case "ModalidadTrabajo":
                        var modalidadTrabajo = await _contexto.modalidadTrabajo.ToListAsync();
                        outPut = _mapper.Map<List<ModalidadTrabajo>, List<ParametricoDTO>>(modalidadTrabajo);
                        break;
                    case "AreaEmpresa":
                        var areaEmpresa = await _contexto.areaEmpresa.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<AreaEmpresa>, List<ParametricoDTO>>(areaEmpresa);
                        break;
                    case "MotivoExcepcionalidad":
                        var motivoExcepcionalidad = await _contexto.motivoExcepcionalidad.ToListAsync();
                        outPut = _mapper.Map<List<MotivoExcepcionalidad>, List<ParametricoDTO>>(motivoExcepcionalidad);
                        break;
                    case "TipoContrato":
                        var tipoContrato = await _contexto.tipoContrato.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<TipoContrato>, List<ParametricoDTO>>(tipoContrato);
                        break;
                    case "JornadaLaboral":
                        var jornada = await _contexto.jornadaLaboral.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<JornadaLaboral>, List<ParametricoDTO>>(jornada);
                        break;
                    case "PeriodicidadSalarial":
                        var periodoRango = await _contexto.periodicidadSalarial.ToListAsync();
                        outPut = _mapper.Map<List<PeriodicidadSalarial>, List<ParametricoDTO>>(periodoRango);
                        break;
                    case "SituacionActualTrabajo":
                        var situacionActualTrabajo = await _contexto.situacionActualTrabajo.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<SituacionActualTrabajo>, List<ParametricoDTO>>(situacionActualTrabajo);
                        break;
                    case "EstadoEducacionNoFormal":
                        var estadoEducacionNoFormal = await _contexto.estadoEducacionNoFormal.ToListAsync();
                        outPut = _mapper.Map<List<EstadoEducacionNoFormal>, List<ParametricoDTO>>(estadoEducacionNoFormal);
                        break;
                    case "AreaConocimiento":
                        var areaConocimiento = await _contexto.areaConocimiento.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<AreaConocimiento>, List<ParametricoDTO>>(areaConocimiento);
                        break;
                    case "Discapacidad":
                        var discapacidad = await _contexto.discapacidad.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<Discapacidad>, List<ParametricoDTO>>(discapacidad);
                        break;
                    case "TituloHomologado":
                        var tituloHomologado = await _contexto.tituloHomologado.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<TituloHomologado>, List<ParametricoDTO>>(tituloHomologado);
                        break;
                    case "Institucion":
                        var institucion = await _contexto.institucion.ToListAsync();
                        outPut = _mapper.Map<List<Institucion>, List<ParametricoDTO>>(institucion);
                        break;
                    case "Profesion":
                        var profesion = await _contexto.profesion.ToListAsync();
                        outPut = _mapper.Map<List<Profesion>, List<ParametricoDTO>>(profesion);
                        break;
                    case "DescripcionExperienciasPrevias":
                        var descripcionExperienciasPrevias = await _contexto.descripcionExperienciasPrevias.ToListAsync();
                        outPut = _mapper.Map<List<DescripcionExperienciasPrevias>, List<ParametricoDTO>>(descripcionExperienciasPrevias);
                        break;
                    case "TipoSalario":
                        var tipoSalario = await _contexto.tipoSalario.ToListAsync();
                        outPut = _mapper.Map<List<TipoSalario>, List<ParametricoDTO>>(tipoSalario);
                        break;
                    case "CondicionSaludMental":
                        var condicionSaludMental = await _contexto.condicionSaludMental.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<CondicionSaludMental>, List<ParametricoDTO>>(condicionSaludMental);
                        break;
                    case "TipoPoblacion":
                        var tipoPoblacion = await _contexto.tipoPoblacion.ToListAsync();
                        outPut = _mapper.Map<List<TipoPoblacion>, List<ParametricoDTO>>(tipoPoblacion);
                        break;
                    case "Localidad":
                        var localidad = await _contexto.localidad.ToListAsync();
                        if (request.municipioID != "0")
                            localidad = await _contexto.localidad.Where(x => x.MunicipioId == request.municipioID).ToListAsync();
                        outPut = _mapper.Map<List<Localidad>, List<ParametricoDTO>>(localidad);
                        break;
                    case "Comuna":
                        var comuna = await _contexto.comuna.ToListAsync();
                        if (request.municipioID != "0")
                            comuna = await _contexto.comuna.Where(x => x.MunicipioId == request.municipioID).ToListAsync();
                        outPut = _mapper.Map<List<Comuna>, List<ParametricoDTO>>(comuna);
                        break;
                    case "TipoProyecto":
                        var tipoProyecto = await _contexto.tipoProyecto.ToListAsync();
                        outPut = _mapper.Map<List<TipoProyecto>, List<ParametricoDTO>>(tipoProyecto);
                        break;
                    case "CUOCDenominacion":
                        var cuocDenominacion = await _contexto.CUOCdenominacion.ToListAsync();
                        outPut = _mapper.Map<List<CUOCDenominacion>, List<ParametricoDTO>>(cuocDenominacion);
                        break;

                    case "CUOCOcupacion": //- no tiene modelo base
                        var cuocOcupacion = await _contexto.CUOCocupacion.ToListAsync();
                        outPut = _mapper.Map<List<CUOCOcupacion>, List<ParametricoDTO>>(cuocOcupacion);
                        break;

                    //case "CUOCOcupacionConocimiento":
                    //    var cUOCOcupacion2 = await _contexto.CUOCConocimientoOcupacion.Include(i => i.CUOCOcupacion).ToListAsync();
                    //    if (request.ConocimientoId != null)
                    //        cUOCOcupacion2 = await _contexto.CUOCConocimientoOcupacion
                    //            .Include(i => i.CUOCOcupacion)
                    //            .Where(x => x.CUOCOcupacionId == request.ConocimientoId).ToListAsync();
                    //    outPut = _mapper.Map<List<CUOCConocimientoOcupacion>, List<ParametricoDTO>>(cUOCOcupacion2);
                    //    break;

                    case "CUOCConocimiento":
                        var conocimientos = await _contexto.CUOCConocimientoOcupacion.Include(i => i.CUOCConocimiento).ToListAsync();
                        if (request.OcupacionId != null)
                            conocimientos = await _contexto.CUOCConocimientoOcupacion
                                .Include(i => i.CUOCConocimiento)
                                .Where(x => x.CUOCOcupacionId == request.OcupacionId).ToListAsync();
                        outPut = _mapper.Map<List<CUOCConocimientoOcupacion>, List<ParametricoDTO>>(conocimientos);
                        break;


                    case "CUOCConocimientoBase":
                        var conocimientoBase = await _contexto.CUOCconocimiento.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<CUOCConocimiento>, List<ParametricoDTO>>(conocimientoBase);
                        break;

                    case "CUOCDestreza":
                        var destrezas = await _contexto.CUOCdestrezaOcupacion.Include(i => i.CUOCDestreza).ToListAsync();
                        if (request.OcupacionId != null)
                            destrezas = await _contexto.CUOCdestrezaOcupacion
                                .Include(i => i.CUOCDestreza)
                                .Where(x => x.CUOCOcupacionId == request.OcupacionId).ToListAsync();
                        outPut = _mapper.Map<List<CUOCDestrezaOcupacion>, List<ParametricoDTO>>(destrezas);
                        break;

                    case "CUOCDestrezaBase":
                        var destrezaBase = await _contexto.CUOCdestreza.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<CUOCDestreza>, List<ParametricoDTO>>(destrezaBase);
                        break;

                    case "ZonaGeografica":
                        var zonaGeografica = await _contexto.zonaGeografica.ToListAsync();
                        outPut = _mapper.Map<List<ZonaGeografica>, List<ParametricoDTO>>(zonaGeografica);
                        break;
                    case "TipoZonaGeografica":
                        var tipoZonaGeografica = await _contexto.tipoZonaGeografica.ToListAsync();
                        outPut = _mapper.Map<List<TipoZonaGeografica>, List<ParametricoDTO>>(tipoZonaGeografica);
                        break;
                    case "TipoLibretaMilitar":
                        var tipoLibretaMilitar = await _contexto.tipoLibretaMilitar.ToListAsync();
                        outPut = _mapper.Map<List<TipoLibretaMilitar>, List<ParametricoDTO>>(tipoLibretaMilitar);
                        break;
                    case "EstadoCiudadano":
                        var estadoCiudadano = await _contexto.estadoCiudadano.ToListAsync();
                        outPut = _mapper.Map<List<EstadoCiudadano>, List<ParametricoDTO>>(estadoCiudadano);
                        break;
                    case "TipoExperienciaPrevia":
                        var tipoExperienciaPrevia = await _contexto.tipoExperienciaPrevia.ToListAsync();
                        outPut = _mapper.Map<List<TipoExperienciaPrevia>, List<ParametricoDTO>>(tipoExperienciaPrevia);
                        break;
                    case "TipoPoblacionVulnerable":
                        var tipoPoblacionVulnerable = await _contexto.tipoPoblacionVulnerable.ToListAsync();
                        outPut = _mapper.Map<List<TipoPoblacionVulnerable>, List<ParametricoDTO>>(tipoPoblacionVulnerable);
                        break;
                    case "RedSocial":
                        var redSocial = await _contexto.redSocial.ToListAsync();
                        outPut = _mapper.Map<List<RedSocial>, List<ParametricoDTO>>(redSocial);
                        break;
                    case "PlantillaMensaje":
                        var plantillasMensaje = await _contexto.plantillaMensaje.ToListAsync();
                        outPut = _mapper.Map<List<PlantillaMensaje>, List<ParametricoDTO>>(plantillasMensaje);
                        break;
                    case "InformacionLaboral":
                        var informacionLaboral = await _contexto.informacionLaboral.ToListAsync();
                        outPut = _mapper.Map<List<InformacionLaboral>, List<ParametricoDTO>>(informacionLaboral);
                        break;
                    case "MensajePreseleccion":
                        var mensajesPreseleccion = await _contexto.mensajePreseleccion.ToListAsync();
                        outPut = _mapper.Map<List<MensajePreseleccion>, List<ParametricoDTO>>(mensajesPreseleccion);
                        break;
                    case "FluidezIdioma":
                        var fluidezIdioma = await _contexto.fluidezIdioma.ToListAsync();
                        outPut = _mapper.Map<List<FluidezIdioma>, List<ParametricoDTO>>(fluidezIdioma);
                        break;
                    case "DireccionTipoVia":
                        var direccionTiposVia = await _contexto.direccionTipoVia.ToListAsync();
                        outPut = _mapper.Map<List<DireccionTipoVia>, List<ParametricoDTO>>(direccionTiposVia);
                        break;
                    case "DireccionLetra":
                        var direccionLetras = await _contexto.direccionLetra.OrderBy(z => z.Nombre).ToListAsync();
                        outPut = _mapper.Map<List<DireccionLetra>, List<ParametricoDTO>>(direccionLetras);
                        break;
                    case "DireccionCuadrante":
                        var direccionCuadrantes = await _contexto.direccionCuadrante.ToListAsync();
                        outPut = _mapper.Map<List<DireccionCuadrante>, List<ParametricoDTO>>(direccionCuadrantes);
                        break;
                    case "DireccionComplemento":
                        var direccionComplementos = await _contexto.direccionComplemento.ToListAsync();
                        outPut = _mapper.Map<List<DireccionComplemento>, List<ParametricoDTO>>(direccionComplementos);
                        break;
                    case "Terminos":
                        var terminos = await _contexto.terminos.ToListAsync();
                        outPut = _mapper.Map<List<Terminos>, List<ParametricoDTO>>(terminos);
                        break;
                    case "MotivoRechazo":
                        var motivosRechazo = await _contexto.motivoRechazo.ToListAsync();
                        outPut = _mapper.Map<List<MotivoRechazo>, List<ParametricoDTO>>(motivosRechazo);
                        break;
                    case "MotivoCambioPrestador":
                        var motivosCambioPrestador = await _contexto.motivoCambioPrestador.ToListAsync();
                        outPut = _mapper.Map<List<MotivoCambioPrestador>, List<ParametricoDTO>>(motivosCambioPrestador);
                        break;
                    case "TipoPrestador":
                        var tiposPrestador = await _contexto.tipoPrestador.ToListAsync();
                        outPut = _mapper.Map<List<TipoPrestador>, List<ParametricoDTO>>(tiposPrestador);
                        break;
                    case "MotivoAmpliarZona":
                        var motivosAmpliarZona = await _contexto.motivoAmpliarZona.ToListAsync();
                        outPut = _mapper.Map<List<MotivoAmpliarZona>, List<ParametricoDTO>>(motivosAmpliarZona);
                        break;
                    case "PlantillaDescripcionVacante":
                        var plantillasDescripcionVacante = await _contexto.plantillaDescripcionVacante.ToListAsync();
                        outPut = _mapper.Map<List<PlantillaDescripcionVacante>, List<ParametricoDTO>>(plantillasDescripcionVacante);
                        break;
                    case "EstadoVacante":
                        var estadosVacante = await _contexto.estadoVacante.ToListAsync();
                        outPut = _mapper.Map<List<EstadoVacante>, List<ParametricoDTO>>(estadosVacante);
                        break;
                    case "CriterioMatch":
                        var criteriosMatch = await _contexto.criterioMatch.ToListAsync();
                        outPut = _mapper.Map<List<CriterioMatch>, List<ParametricoDTO>>(criteriosMatch);
                        break;
                    case "AreaInfluencia":
                        var areasInfluencia = await _contexto.areaInfluencia.ToListAsync();
                        outPut = _mapper.Map<List<AreaInfluencia>, List<ParametricoDTO>>(areasInfluencia);
                        break;
                    case "DivisionTerritorial":
                        var divisionesTerritoriales = await _contexto.divisionTerritorial.ToListAsync();
                        outPut = _mapper.Map<List<DivisionTerritorial>, List<ParametricoDTO>>(divisionesTerritoriales);
                        break;
                    case "NucleoConocimientoHidrocarburos":
                        var nucleoConocimientoHidrocarburos = await _contexto.nucleoConocimientoHidrocarburos.ToListAsync();
                        outPut = _mapper.Map<List<NucleoConocimientoHidrocarburos>, List<ParametricoDTO>>(nucleoConocimientoHidrocarburos);
                        break;
                    case "ConfiguracionAvanceHojaVida":
                        var configuracionAvanceHojaVida = await _contextoCiudadano.configuracionAvanceHojaVida.ToListAsync();
                        outPut = _mapper.Map<List<ConfiguracionAvanceHojaVida>, List<ParametricoDTO>>(configuracionAvanceHojaVida);
                        break;
                    case "TipoVacante":
                        var tiposVacante = await _contexto.tipoVacante.ToListAsync();
                        outPut = _mapper.Map<List<TipoVacante>, List<ParametricoDTO>>(tiposVacante);
                        break;
                    case "NumeroIntentosIngreso":
                        var numeroIntentos = await _contexto.NumeroIntentos.ToListAsync();
                        outPut = _mapper.Map<List<NumeroIntentos>, List<ParametricoDTO>>(numeroIntentos);
                        break;
                    case "CierreSesion":
                        var cierreSesion = await _contexto.CierreSesion.ToListAsync();
                        outPut = _mapper.Map<List<CierreSesion>, List<ParametricoDTO>>(cierreSesion);
                        break;
                    case "ControlPesoNumeroArchivosCargar":
                        var data = await _contexto.ControlPesoNumeroArchivosCargar.ToListAsync();
                        outPut = _mapper.Map<List<ControlPesoNumeroArchivosCargar>, List<ParametricoDTO>>(data);
                        break;
                    case "EstadoFasesProcesoSeleccion":
                        var estadoFasesProcSel = await _contexto.EstadoFasesProcesoSeleccion.ToListAsync();
                        outPut = _mapper.Map<List<EstadoFasesProcesoSeleccion>, List<ParametricoDTO>>(estadoFasesProcSel);
                        break;
                    case "InactivarCuentaEmpresarial":
                        var inactivarCuentaEmpresarial = await _contexto.InactivarCuentaEmpresarial.ToListAsync();
                        outPut = _mapper.Map<List<InactivarCuentaEmpresarial>, List<ParametricoDTO>>(inactivarCuentaEmpresarial);
                        foreach (var outItem in outPut)
                        {
                            var inactivarItem = inactivarCuentaEmpresarial.FirstOrDefault(i => i.Id == Convert.ToInt32(outItem.Id));
                            if (inactivarItem != null)
                            {
                                outItem.TipoRespuesta = Convert.ToString(inactivarItem.TipoPreguntasId);
                            }
                        }
                        break;
                    case "IndicadorSatisfaccionDiligenciamiento":
                        var indicadorSatisfaccionDiligenciamientos = await _contexto.IndicadorSatisfaccionDiligenciamiento.ToListAsync();
                        outPut = _mapper.Map<List<IndicadorSatisfaccionDiligenciamiento>, List<ParametricoDTO>>(indicadorSatisfaccionDiligenciamientos);
                        break;
                    case "IndicadorSatisfaccionManejoHerramienta":
                        var indicadorSatisfaccionManejoHerramientas = await _contexto.IndicadorSatisfaccionManejoHerramienta.ToListAsync();
                        outPut = _mapper.Map<List<IndicadorSatisfaccionManejoHerramienta>, List<ParametricoDTO>>(indicadorSatisfaccionManejoHerramientas);
                        break;
                    case "FlujoEncuestaSatisfaccionAsistenciaIngreso":
                        var flujoEncuestaSatisfaccionAsistenciaIngreso = await _contexto.FlujoEncuestaSatisfaccionAsistIngresos.ToListAsync();
                        outPut = _mapper.Map<List<FlujoEncuestaSatisfaccionAsistIngreso>, List<ParametricoDTO>>(flujoEncuestaSatisfaccionAsistenciaIngreso);
                        break;
                    case "PreguntasFrecuentes":
                        var preguntasFrecuentes = await _contexto.PreguntasFrecuentes.ToListAsync();
                        outPut = _mapper.Map<List<PreguntasFrecuentes>, List<ParametricoDTO>>(preguntasFrecuentes);
                        break;
                    case "RecepcionNotificaciones":
                        var recepcionNotificaciones = await _contexto.RecepcionNotificaciones
                                                    .Include(e => e.Notificaciones)
                                                    .ToListAsync();

                        outPut = _mapper.Map<List<RecepcionNotificaciones>, List<ParametricoDTO>>(recepcionNotificaciones);
                        break;
                    case "CanalesNotificacion":
                        var canalesNotificacions = await _contexto.CanalesNotificacion.ToListAsync();
                        outPut = _mapper.Map<List<CanalesNotificacion>, List<ParametricoDTO>>(canalesNotificacions);
                        break;
                    case "EncuestaSistema":
                        var encuestaSistema = _contexto.EncuestaSistema
                                                .Include(e => e.Preguntas)
                                                .Include(m => m.Modulo)
                                                .ToList();

                        outPut = _mapper.Map<List<EncuestaSistema>, List<ParametricoDTO>>(encuestaSistema);
                        break;
                    case "TipoPreguntas":
                        var tipoPreguntas = await _contexto.TipoPreguntas.ToListAsync();
                        outPut = _mapper.Map<List<TipoPreguntas>, List<ParametricoDTO>>(tipoPreguntas);
                        break;
                    case "PasosRutaEmpleabilidad":
                        var pasosRutaEmpleabilidad = await _contexto.PasosRutaEmpleabilidad
                                                        .Include(p => p.Direccionamientos)
                                                        .ToListAsync();
                        outPut = _mapper.Map<List<PasosRutaEmpleabilidad>, List<ParametricoDTO>>(pasosRutaEmpleabilidad);
                        break;
                    case "InactivacionCuenta":
                        var inactivacionCuentas = await _contexto.InactivacionCuenta
                                                        .Include(p => p.RolModel)
                                                        .ToListAsync();
                        outPut = _mapper.Map<List<InactivacionCuenta>, List<ParametricoDTO>>(inactivacionCuentas);
                        break;
                    case "EstadoCandidato":
                        var estadoCandidatos = await _contexto.EstadoCandidato.ToListAsync();
                        outPut = _mapper.Map<List<EstadoCandidato>, List<ParametricoDTO>>(estadoCandidatos);
                        break;
                    case "CampoCertificadoEstadoVacante":
                        var campoCertificadoEstadoVacantes = await _contexto.CampoCertificadoEstadoVacantes.ToListAsync();
                        outPut = _mapper.Map<List<CampoCertificadoEstadoVacante>, List<ParametricoDTO>>(campoCertificadoEstadoVacantes);
                        break;
                    case "AdministrarNaturaleza":
                        var administrarNaturalezas = await _contexto.AdministrarNaturaleza.ToListAsync();
                        outPut = _mapper.Map<List<AdministrarNaturaleza>, List<ParametricoDTO>>(administrarNaturalezas);
                        break;
                    case "AdministrarTipo":
                        var administrarTipos = await _contexto.AdministrarTipo.ToListAsync();
                        outPut = _mapper.Map<List<AdministrarTipo>, List<ParametricoDTO>>(administrarTipos);
                        break;
                    case "AdministrarTamano":
                        var administrarTamanos = await _contexto.AdministrarTamano.ToListAsync();
                        outPut = _mapper.Map<List<AdministrarTamano>, List<ParametricoDTO>>(administrarTamanos);
                        break;
                    case "AdministraProgramaEmpleo":
                        var administraProgramaEmpleos = await _contexto.AdministraProgramaEmpleo.ToListAsync();
                        outPut = _mapper.Map<List<AdministraProgramaEmpleo>, List<ParametricoDTO>>(administraProgramaEmpleos);
                        break;
                    case "AdministraGrupoEspeciales":
                        var administraGrupoEspeciales = await _contexto.AdministraGrupoEspecial.ToListAsync();
                        outPut = _mapper.Map<List<AdministraGrupoEspeciales>, List<ParametricoDTO>>(administraGrupoEspeciales);
                        break;
                    case "AdministraMotivoProcesoSeleccionCandidato":
                        var administraMotivoProcesoSeleccionCandidatos = await _contexto.AdministraMotivoProcesoSeleccionCandidatos.ToListAsync();
                        outPut = _mapper.Map<List<AdministraMotivoProcesoSeleccionCandidato>, List<ParametricoDTO>>(administraMotivoProcesoSeleccionCandidatos);
                        break;
                    case "AdministraPortafolioServicioOrientacionBuscador":
                        var administraPortafolioServicioOrientacionBuscadors = await _contexto.AdministraPortafolioServicioOrientacionBuscador.ToListAsync();
                        outPut = _mapper.Map<List<AdministraPortafolioServicioOrientacionBuscador>, List<ParametricoDTO>>(administraPortafolioServicioOrientacionBuscadors);
                        break;
                    case "AdministraPortafolioServicioOrientacionEmpleador":
                        var administraPortafolioServicioOrientacionEmpleadors = await _contexto.AdministraPortafolioServicioOrientacionEmpleador.ToListAsync();
                        outPut = _mapper.Map<List<AdministraPortafolioServicioOrientacionEmpleador>, List<ParametricoDTO>>(administraPortafolioServicioOrientacionEmpleadors);
                        break;
                    case "ParametrizaOfertaModalidad":
                        var parametrizaOfertaModalidads = await _contexto.ParametrizaOfertaModalidad.ToListAsync();
                        outPut = _mapper.Map<List<ParametrizaOfertaModalidad>, List<ParametricoDTO>>(parametrizaOfertaModalidads);
                        break;
                    case "ParametrizaOfertaModoAsistencia":
                        var parametrizaOfertaModoAsistencias = await _contexto.ParametrizaOfertaModoAsistencia.ToListAsync();
                        outPut = _mapper.Map<List<ParametrizaOfertaModoAsistencia>, List<ParametricoDTO>>(parametrizaOfertaModoAsistencias);
                        break;
                    case "ParametrizaOfertaTipoOferta":
                        var parametrizaOfertaTipoOfertas = await _contexto.ParametrizaOfertaTipoOferta.ToListAsync();
                        outPut = _mapper.Map<List<ParametrizaOfertaTipoOferta>, List<ParametricoDTO>>(parametrizaOfertaTipoOfertas);
                        break;
                    case "SemanaCotizar":
                        var semanaCotizars = await _contexto.SemanaCotizar.ToListAsync();
                        outPut = _mapper.Map<List<SemanaCotizar>, List<ParametricoDTO>>(semanaCotizars);
                        break;
                    case "ControlSemanasCotizacion":
                        var controlSemanaCotizacions = await _contexto.ControlSemanaCotizacion.ToListAsync();
                        outPut = _mapper.Map<List<ControlSemanaCotizacion>, List<ParametricoDTO>>(controlSemanaCotizacions);
                        break;
                    case "CatalogoEstadoCursos":
                        var catalogoEstadoCursos = await _contexto.CatalogoEstadoCurso.ToListAsync();
                        outPut = _mapper.Map<List<CatalogoEstadoCurso>, List<ParametricoDTO>>(catalogoEstadoCursos);
                        break;
                    case "CriteriosVideos":
                        var criterioVideos = await _contexto.CriterioVideo.ToListAsync();
                        outPut = _mapper.Map<List<CriterioVideo>, List<ParametricoDTO>>(criterioVideos);
                        break;
                    case "ConfiguraPlantillaMensaje":
                        var configuraPlantillaMensajes = await _contexto.ConfiguraPlantillaMensaje.ToListAsync();
                        outPut = _mapper.Map<List<ConfiguraPlantillaMensaje>, List<ParametricoDTO>>(configuraPlantillaMensajes);
                        break;

                    case "MotivosInactivacionBuscador":
                        var motivosInactivacionBuscador = await _contexto.MotivoInactivacionBuscador.ToListAsync();
                        outPut = _mapper.Map<List<MotivoInactivacionBuscador>, List<ParametricoDTO>>(motivosInactivacionBuscador);
                        break;
                    case "NotificacionesAlarmas":
                        var notificacionesAlarmas = await _contexto.NotificacionesAlarmas.ToListAsync();
                        outPut = _mapper.Map<List<NotificacionesAlarmas>, List<ParametricoDTO>>(notificacionesAlarmas);
                        break;
                    case "SalidaPlanMejoramiento":
                        var campoSalidaPlanMejoramientos = await _contexto.CampoSalidaPlanMejoramiento.ToListAsync();
                        outPut = _mapper.Map<List<CampoSalidaPlanMejoramiento>, List<ParametricoDTO>>(campoSalidaPlanMejoramientos);
                        break;

                    case "PrestadoresExternos":
                        var prestadoresExternos = await _contexto.PrestadoresExternos.ToListAsync();
                        outPut = _mapper.Map<List<PrestadoresExternos>, List<ParametricoDTO>>(prestadoresExternos);
                        break;
                    case "CursoFortalecimiento":
                        var cursoFortalecimientos = await _contexto.CursoFortalecimiento.ToListAsync();
                        outPut = _mapper.Map<List<CursoFortalecimiento>, List<ParametricoDTO>>(cursoFortalecimientos);
                        break;
                    case "CamposCreacionEmpresaExtrangera":
                        var camposCreacionEmpresaExtrangera = await _contexto.CamposCreacionEmpresaExtrangera.ToListAsync();
                        outPut = _mapper.Map<List<CamposCreacionEmpresaExtrangera>, List<ParametricoDTO>>(camposCreacionEmpresaExtrangera);
                        break;
                    case "PaisInternacional":
                        var paisInternacional = await _contexto.PaisInternacional.OrderBy(z => z.Nombre).ToListAsync();

                        outPut = _mapper.Map<List<PaisInternacional>, List<ParametricoDTO>>(paisInternacional);
                        break;
                    case "DepartamentoInternacional":
                        var departamentoInternacional = await _contexto.DepartamentoInternacional.OrderBy(z => z.Nombre).ToListAsync();

                        outPut = _mapper.Map<List<DepartamentoInternacional>, List<ParametricoDTO>>(departamentoInternacional);
                        break;
                    case "MunicipioInternacional":
                        var municipioInternacional = await _contexto.MunicipioInternacional.OrderBy(z => z.Nombre).ToListAsync();

                        outPut = _mapper.Map<List<MunicipioInternacional>, List<ParametricoDTO>>(municipioInternacional);
                        break;
                    case "BarrerasFormacion":
                        var barrerasFormacion = await _contexto.BarreraFormacion.ToListAsync();

                        outPut = _mapper.Map<List<BarreraFormacion>, List<ParametricoDTO>>(barrerasFormacion);
                        break;
                    case "BarrerasDestrezas":
                        var barreraDestrezas = await _contexto.BarreraDestrezas.ToListAsync();

                        outPut = _mapper.Map<List<BarreraDestrezas>, List<ParametricoDTO>>(barreraDestrezas);
                        break;
                    case "BarreraConocimientoEspecifico":
                        var barreraConocimientoEspecifico = await _contexto.BarreraConocimientoEspecifico.ToListAsync();

                        outPut = _mapper.Map<List<BarreraConocimientoEspecifico>, List<ParametricoDTO>>(barreraConocimientoEspecifico);
                        break;
                    case "BarreraManejoTic":
                        var barreraManejoTic = await _contexto.BarreraManejoTic.ToListAsync();

                        outPut = _mapper.Map<List<BarreraManejoTic>, List<ParametricoDTO>>(barreraManejoTic);
                        break;
                    case "BarreraServicioAlCliente":
                        var barreraServicioAlCliente = await _contexto.BarreraServicioAlCliente.ToListAsync();

                        outPut = _mapper.Map<List<BarreraServicioAlCliente>, List<ParametricoDTO>>(barreraServicioAlCliente);
                        break;
                    case "BarreraGerenciaAdministracion":
                        var barreraGerenciaAdministracion = await _contexto.BarreraGerenciaAdministracion.ToListAsync();

                        outPut = _mapper.Map<List<BarreraGerenciaAdministracion>, List<ParametricoDTO>>(barreraGerenciaAdministracion);
                        break;
                    case "EtapaSeguroDesempleo":
                        var etapaSeguroDesempleo = await _contexto.EtapaSeguroDesempleo.ToListAsync();

                        outPut = _mapper.Map<List<EtapaSeguroDesempleo>, List<ParametricoDTO>>(etapaSeguroDesempleo);
                        break;
                    case "PreguntasBarreraDocumental":
                        var barreraDocumentalPreguntas = await _contexto.BarreraDocumentalPreguntas.ToListAsync();

                        outPut = _mapper.Map<List<BarreraDocumentalPreguntas>, List<ParametricoDTO>>(barreraDocumentalPreguntas);
                        break;
                    case "PreguntasBarreraEntorno":
                        var barreraEntornoPreguntas = await _contexto.BarreraEntornoPreguntas.ToListAsync();

                        outPut = _mapper.Map<List<BarreraEntornoPreguntas>, List<ParametricoDTO>>(barreraEntornoPreguntas);
                        break;




                    case "Modulo":
                        var Modulos = await _contexto.Modulo.ToListAsync();
                        List<ParametricoDTO> lstModulos = new List<ParametricoDTO>();
                        foreach (var item in Modulos)
                        {
                            ParametricoDTO objModulo = new ParametricoDTO();
                            objModulo.Descripcion = item.Descripcion;
                            objModulo.Id = item.Id.ToString();
                            lstModulos.Add(objModulo);
                        }
                        outPut = lstModulos;
                        break;

                    case "Rol":
                        var rol = await _contexto.Rol.ToListAsync();
                        List<ParametricoDTO> lstRoles = new List<ParametricoDTO>();
                        foreach (var item in rol)
                        {
                            ParametricoDTO objModulo = new ParametricoDTO();
                            objModulo.Descripcion = item.Descripcion;
                            objModulo.Id = item.Id.ToString();
                            lstRoles.Add(objModulo);
                        }
                        outPut = lstRoles;
                        break;

                    case "ViaPrincipal":
                        var viaPrincipal = await _contexto.ViaPrincipal.ToListAsync();
                        List<ParametricoDTO> lstViaPrincipal = new List<ParametricoDTO>();
                        foreach (var item in viaPrincipal)
                        {
                            ParametricoDTO objViaPrincipal = new ParametricoDTO();
                            objViaPrincipal.Nombre = item.Nombre;
                            objViaPrincipal.Id = item.Id.ToString();
                            lstViaPrincipal.Add(objViaPrincipal);
                        }
                        outPut = lstViaPrincipal;
                        break;

                    case "ViaComplemento":
                        var viaComplemento = await _contexto.ViaComplemento.ToListAsync();
                        List<ParametricoDTO> lstViaComplemento = new List<ParametricoDTO>();
                        foreach (var item in viaComplemento)
                        {
                            ParametricoDTO objViaComplemento = new ParametricoDTO();
                            objViaComplemento.Nombre = item.Nombre;
                            objViaComplemento.Id = item.Id.ToString();
                            lstViaComplemento.Add(objViaComplemento);
                        }
                        outPut = lstViaComplemento;
                        break;
                    //HU0099
                    case "ServiciosBasicos":
                        var serviciosBasicos = await _contexto.ServiciosBasicos.ToListAsync();
                        outPut = _mapper.Map<List<ServiciosBasicos>, List<ParametricoDTO>>(serviciosBasicos);
                        break;

                    case "ServiciosAsociados":
                        var serviciosAsociados = await _contexto.ServiciosAsociados.ToListAsync();
                        outPut = _mapper.Map<List<ServiciosAsociados>, List<ParametricoDTO>>(serviciosAsociados);
                        break;

                    case "ServiciosOferta":
                        var serviciosOferta = await _contexto.ServiciosOferta.ToListAsync();
                        outPut = _mapper.Map<List<ServiciosOferta>, List<ParametricoDTO>>(serviciosOferta);
                        break;

                    case "BrechaServiciosAsociados":
                        var brechaServiciosAsociados = await _contexto.BrechaServiciosAsociados.ToListAsync();
                        outPut = _mapper.Map<List<BrechaServiciosAsociados>, List<ParametricoDTO>>(brechaServiciosAsociados);
                        break;

                    case "BrechaServiciosBasicos":
                        var brechaServiciosBasicos = await _contexto.BrechaServiciosBasicos.ToListAsync();
                        outPut = _mapper.Map<List<BrechaServiciosBasicos>, List<ParametricoDTO>>(brechaServiciosBasicos);
                        break;

                    case "BrechaServiciosOferta":
                        var brechaServiciosOferta = await _contexto.BrechaServiciosOferta.ToListAsync();
                        outPut = _mapper.Map<List<BrechaServiciosOferta>, List<ParametricoDTO>>(brechaServiciosOferta);
                        break;

                    case "ServiciosAsociadosBrecha":
                        var serviciosAsociadosBrecha = await _contexto.ServiciosAsociadosBrecha.Include(i => i.BrechaServiciosAsociados).ToListAsync();
                        if (request.ServiciosAsociadosId != null)
                            serviciosAsociadosBrecha = await _contexto.ServiciosAsociadosBrecha
                                .Include(i => i.BrechaServiciosAsociados)
                                .Where(x => x.ServiciosAsociadosId == int.Parse(request.ServiciosAsociadosId)).ToListAsync();
                        outPut = _mapper.Map<List<ServiciosAsociadosBrecha>, List<ParametricoDTO>>(serviciosAsociadosBrecha);
                        break;

                    case "ServiciosBasicosBrecha":
                        var serviciosBasicosBrecha = await _contexto.ServiciosBasicosBrecha.Include(i => i.BrechaServiciosBasicos).ToListAsync();
                        if (request.ServiciosBasicosId != null)
                            serviciosBasicosBrecha = await _contexto.ServiciosBasicosBrecha
                                .Include(i => i.BrechaServiciosBasicos)
                                .Where(x => x.ServiciosBasicosId == int.Parse(request.ServiciosBasicosId)).ToListAsync();
                        outPut = _mapper.Map<List<ServiciosBasicosBrecha>, List<ParametricoDTO>>(serviciosBasicosBrecha);
                        break;

                    case "ServiciosOfertaBrecha":
                        var serviciosOfertaBrecha = await _contexto.ServiciosOfertaBrecha.Include(i => i.BrechaServiciosOferta).ToListAsync();
                        if (request.ServiciosOfertaId != null)
                            serviciosOfertaBrecha = await _contexto.ServiciosOfertaBrecha
                                .Include(i => i.BrechaServiciosOferta)
                                .Where(x => x.ServiciosOfertaId == int.Parse(request.ServiciosOfertaId)).ToListAsync();
                        outPut = _mapper.Map<List<ServiciosOfertaBrecha>, List<ParametricoDTO>>(serviciosOfertaBrecha);
                        break;

                    //HU0099
                    default:
                        throw new Exception($"{request.tipo} tipo no valido");
                }
                return outPut;
            }
        }
    }
}
