using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion
{
    public class Consulta
    {
        public class ConsultaParametrico : IRequest<ConsultaDTO>
        {
            public int? TipoDocumentoId { get; set; }
            public string? DepartamentoId { get; set; }
            public string? MunicipioId { get; set; }
            public int? PaisId { get; set; }
            public int? GeneroId { get; set; }
            public int? EstadoCivilId { get; set; }
            public string? PaisNacimientoId { get; set; }
            public string? DepartamentoNacimientoId { get; set; }
            public string? MunicipioNacimientoId { get; set; }
            public string? EpsId { get; set; }
            public int? RangoSalarialId { get; set; }
            public int? GrupoEtnicoId { get; set; }
            public int? CondicionDiscapacidadId { get; set; }
            public int? CondicionSaludMentalId { get; set; }
            public int? CategoriaLicenciaCarroId { get; set; }
            public int? CategoriaLicenciaMotoId { get; set; }
            public int? SituacionLaboralActualId { get; set; }
            public int? PerteneceAId { get; set; }
            public int? TipoPoblacionId { get; set; }
            public int? TipoExperienciaId { get; set; }
            public int? SectorId { get; set; }
            public int? CargoEquivalenteId { get; set; }
            public int? OcupacionEquivalenteId { get; set; }
            public int? ConocimientoId { get; set; }
            public int? HabilidadId { get; set; }
            public int? TipoNotificacionId { get; set; }
            public int? CargiInteresId { get; set; }
            public int? ZonaGeograficaId { get; set; }
            public int? LocalidadComunaId { get; set; }
            public int? ServiciosBasicosId { get; set; }
            public int? ServiciosAsociadosId { get; set; }
            public int? ServiciosOfertaId { get; set; }
            public int? BrechaServiciosAsociadosId { get; set; }
            public int? BrechaServiciosBasicosId { get; set; }
            public int? BrechaServiciosOfertaId { get; set; }
        }


        public class Manejador : IRequestHandler<ConsultaParametrico, ConsultaDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ConsultaDTO> Handle(ConsultaParametrico request, CancellationToken cancellationToken)
            {
                try
                {
                    ConsultaDTO? outPut = new ConsultaDTO();

                    #region HU0099
                    if (request.ServiciosBasicosId is not null)
                    {
                        var serviciosBasicos = await _contexto.ServiciosBasicos.FindAsync(request.ServiciosBasicosId);
                        outPut.ServiciosBasicos = _mapper.Map<ServiciosBasicos, ParametricoDTO>(serviciosBasicos);
                    }

                    if (request.ServiciosAsociadosId is not null)
                    {
                        var serviciosAsociados = await _contexto.ServiciosAsociados.FindAsync(request.ServiciosAsociadosId);
                        outPut.ServiciosAsociados = _mapper.Map<ServiciosAsociados, ParametricoDTO>(serviciosAsociados);
                    }

                    if (request.ServiciosOfertaId is not null)
                    {
                        var serviciosOferta = await _contexto.ServiciosOferta.FindAsync(request.ServiciosOfertaId);
                        outPut.ServiciosOferta = _mapper.Map<ServiciosOferta, ParametricoDTO>(serviciosOferta);
                    }

                    if (request.BrechaServiciosAsociadosId is not null)
                    {
                        var brechaServiciosAsociados = await _contexto.BrechaServiciosAsociados.FindAsync(request.BrechaServiciosAsociadosId);
                        outPut.BrechaServiciosAsociados = _mapper.Map<BrechaServiciosAsociados, ParametricoDTO>(brechaServiciosAsociados);
                    }

                    if (request.BrechaServiciosBasicosId is not null)
                    {
                        var brechaServiciosBasicos = await _contexto.BrechaServiciosBasicos.FindAsync(request.BrechaServiciosBasicosId);
                        outPut.BrechaServiciosBasicos = _mapper.Map<BrechaServiciosBasicos, ParametricoDTO>(brechaServiciosBasicos);
                    }

                    if (request.BrechaServiciosOfertaId is not null)
                    {
                        var brechaServiciosOferta = await _contexto.BrechaServiciosOferta.FindAsync(request.BrechaServiciosOfertaId);
                        outPut.BrechaServiciosOferta = _mapper.Map<BrechaServiciosOferta, ParametricoDTO>(brechaServiciosOferta);
                    }
                    #endregion

                    if (request.TipoDocumentoId is not null)
                    {
                        var tipoDocumento = await _contexto.tipoDocumento.FindAsync(request.TipoDocumentoId);
                        outPut.TipoDocumento = _mapper.Map<TipoDocumento, ParametricoDTO>(tipoDocumento);
                    }
                    if (request.DepartamentoId is not null)
                    {
                        var departamento = await _contexto.departamento.FindAsync(request.DepartamentoId);
                        outPut.Departamento = _mapper.Map<Departamento, ParametricoDTO>(departamento);
                    }

                    if (request.MunicipioId is not null)
                    {
                        var municipio = await _contexto.municipio.FindAsync(request.MunicipioId);
                        outPut.Municipio = _mapper.Map<Municipio, ParametricoDTO>(municipio);
                    }
                    if (request.GeneroId is not null)
                    {
                        var genero = await _contexto.genero.FindAsync(request.GeneroId);
                        outPut.Genero = _mapper.Map<Genero, ParametricoDTO>(genero);
                    }
                    if (request.PaisId is not null)
                    {
                        var pais = await _contexto.pais.FindAsync(request.PaisId);
                        outPut.Pais = _mapper.Map<Pais, ParametricoDTO>(pais);
                    }

                    if (request.ZonaGeograficaId is not null)
                    {
                        var ZonaGeografica = await _contexto.localidad.FindAsync(request.ZonaGeograficaId);
                        outPut.ZonaGeografica = _mapper.Map<Localidad, ParametricoDTO>(ZonaGeografica);
                    }

                    if (request.LocalidadComunaId is not null)
                    {
                        var LocalidadComuna = await _contexto.localidad.FindAsync(request.LocalidadComunaId);
                        outPut.LocalidadComuna = _mapper.Map<Localidad, ParametricoDTO>(LocalidadComuna);
                    }


                    if (outPut is null)
                    {
                        throw new Exception($"no encontrado");
                    }
                    return outPut;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

    }
}
