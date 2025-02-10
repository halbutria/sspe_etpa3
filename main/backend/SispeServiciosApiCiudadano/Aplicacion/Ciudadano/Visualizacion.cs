using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServiciosApiCiudadano.Aplicacion.Utils;
using System.Linq;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class Visualizacion
    {
        public class Ejecuta : IRequest<CiudadanoVisualizacionDTO>
        {
            public Guid? Id { get; set; }
            public string? NumeroDocumento { get; set; }
            public int? TipoDocumentoId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoVisualizacionDTO>
        {
            private readonly Contexto _contexto;
            private readonly ContextoParametrico _contextoParametrico;
            private readonly IMapper _mapper;
            private readonly ConvertirCiudadanoAPersona _aPersona;

            public Manejador(Contexto contexto, ContextoParametrico contextoParametrico, IMapper mapper, ConvertirCiudadanoAPersona aPersona)
            {
                _contexto = contexto;
                _contextoParametrico = contextoParametrico;
                _mapper = mapper;
                _aPersona = aPersona;
            }

            public async Task<CiudadanoVisualizacionDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CiudadanoInformacionLaboralModel, InformacionLaboralDTO>();
                });
                IMapper mapperr = config.CreateMapper();


                var query = _contexto.Ciudadano.Include(i => i.CargoInteres);
                var ciudadano = new CiudadanoModel();
                List<string> cargoIneteres = new List<string>();
                List<int> condicionDiscapacidad = new List<int>();
                List<int> condicionSaludMental = new List<int>();
                List<int> tipoPoblacion = new List<int>();
                List<int> grupoEtnico = new List<int>();

                try
                {
                    if (request.Id is not null)
                    {
                        ciudadano = await query
                        .Include("Direcciones.DireccionComplemento")
                        .Include(i => i.Discapacidad)
                        .Include(i => i.CondicionMental)
                        .Include(i => i.TipoPoblacion)
                        .Include(i => i.CargoInteres)
                        .Include(i => i.GrupoEtnico)
                        .Where(x => x.Id == request.Id)
                        .FirstOrDefaultAsync();

                    }
                    else if (request.TipoDocumentoId is not null && request.NumeroDocumento is not null)
                    {
                        ciudadano = await query
                            .Include("Direcciones.DireccionComplemento")
                            .Include(i => i.Discapacidad)
                            .Include(i => i.CondicionMental)
                            .Include(i => i.TipoPoblacion)
                            .Include(i => i.CargoInteres)
                            .Include(i => i.GrupoEtnico)
                            .Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento && x.Activo == true)
                            .FirstOrDefaultAsync();                        
                    }

                    if (ciudadano is not null)
                    {                        
                        var mapp = _mapper.Map<CiudadanoModel, CiudadanoVisualizacionDTO>(ciudadano);



                        var tipoDocumentoNombre = await _contextoParametrico.tipoDocumento
                        .Where(td => td.Id == ciudadano.TipoDocumentoId)
                        .Select(td => td.Nombre)
                        .FirstOrDefaultAsync();


                        foreach (var tp in ciudadano.CargoInteres)
                            cargoIneteres.Add(tp.CargoInteresId);

                        foreach (var tp in ciudadano.Discapacidad)
                            condicionDiscapacidad.Add(tp.DisacapacidaId);

                        foreach (var tp in ciudadano.CondicionMental)
                            condicionSaludMental.Add(tp.CondicionMentalId);

                        foreach (var tp in ciudadano.TipoPoblacion)
                            tipoPoblacion.Add(tp.TipoPoblacionId);

                        foreach (var ge in ciudadano.GrupoEtnico)
                            grupoEtnico.Add(ge.GrupoEtnicoId);


                        mapp.TipoDocumento = tipoDocumentoNombre;

                        mapp.CargoIneteres = await GetCargoNombres(cargoIneteres);
                        mapp.CondicionDiscapacidad = await GetCondicionesDiscapacidad(condicionDiscapacidad);
                        mapp.CondicionSaludMental = condicionSaludMental;
                        mapp.TipoPoblacion = tipoPoblacion;
                        mapp.GrupoEtnico = grupoEtnico;

                        var queryPais = _contextoParametrico.pais.Where(a => a.Id.Equals(mapp.NacionalidadId));
                        var nacionalidad = await queryPais.Where(x => x.Id == mapp.NacionalidadId).FirstOrDefaultAsync(cancellationToken: cancellationToken);
                        mapp.Nacionalidad = nacionalidad != null ? new SispeServiciosApiCiudadano.Modelo.Parametricos.Pais { Id = nacionalidad.Id, Nombre = nacionalidad.Nombre, Nacionalidad = nacionalidad.Nacionalidad, Sigla = nacionalidad.Sigla, Eliminado = nacionalidad.Eliminado } : null;

                        var queryGenero = _contextoParametrico.genero.Where(a => a.Id.Equals(mapp.SexoId));
                        var genero = await queryGenero.Where(a => a.Id == mapp.SexoId).FirstOrDefaultAsync(cancellationToken: cancellationToken);
                        mapp.GeneroCiudadano = genero != null ? new SispeServiciosApiCiudadano.Modelo.Parametricos.Genero { Id = genero.Id, Nombre = genero.Nombre, Sigla = genero.Sigla, Eliminado = genero.Eliminado } : null;

                        var queryPaisResidencia = _contextoParametrico.pais.Where(a => a.Id.Equals(mapp.PaisResidenciaId));
                        var PaisResidencia = await queryPaisResidencia.Where(x => x.Id == mapp.PaisResidenciaId).FirstOrDefaultAsync(cancellationToken: cancellationToken);
                        mapp.PaisResidencia = PaisResidencia != null ? new SispeServiciosApiCiudadano.Modelo.Parametricos.Pais { Id = PaisResidencia.Id, Nombre = PaisResidencia.Nombre, Nacionalidad = PaisResidencia.Nacionalidad, Sigla = PaisResidencia.Sigla, Eliminado = PaisResidencia.Eliminado } : null;

                        var queryDepartamentos = _contextoParametrico.departamento.ToList();
                        var queryMunicipios = _contextoParametrico.municipio.ToList();

                        if (mapp.MunicipioResidenciaId != string.Empty)
                        {
                            var municipio = queryMunicipios.Where(a => a.Id == mapp.MunicipioResidenciaId).FirstOrDefault().Nombre;
                            mapp.MunicipioResidencia = municipio;
                        }

                        if (mapp.DepartamentoResidenciaId != string.Empty)
                        {
                            var departamento = queryDepartamentos.Where(a => a.Id == mapp.DepartamentoResidenciaId).FirstOrDefault().Nombre;
                            mapp.DepartamentoResidencia = departamento;
                        }

                        var queryInformacionLaboral = _contexto.CiudadanoInformacionLaboral.Where(a => a.CiudadanoId.Equals(mapp.Id));
                        var listInformacionLaboral = queryInformacionLaboral.Where(x => x.CiudadanoId == mapp.Id).ToList();
                        var queryHabilidadLaboral = _contextoParametrico.CUOCdestreza.ToList();
                        var queryConocimientoLaboral = _contextoParametrico.CUOCconocimiento.ToList();

                        List<InformacionLaboralDTO> listInfoLaboral = CargaInformacionLaboral(mapp, listInformacionLaboral, queryHabilidadLaboral, queryConocimientoLaboral);

                        mapp.InformacionLaboral = listInfoLaboral;

                        var queryEducacionFormal = _contexto.CiudadanoEducacionFormal.Where(a => a.CiudadanoId.Equals(mapp.Id));
                        var listEducacionFormal = queryEducacionFormal.Where(a => a.CiudadanoId == mapp.Id).ToList();

                        foreach (var item in listEducacionFormal)
                        {
                            var queryNivelEducativo = _contextoParametrico.nivelEducativo.Where(a => a.Id.Equals(item.NivelEducativoId));
                            var NivelEducativo = await queryNivelEducativo.Where(a => a.Id == item.NivelEducativoId).FirstOrDefaultAsync(cancellationToken: cancellationToken);
                            item.NivelEducativo = NivelEducativo != null ? new SispeServiciosApiCiudadano.Modelo.Parametricos.NivelEducativo { Id = Convert.ToInt32(NivelEducativo.Id), Nombre = NivelEducativo.Nombre, Orden = Convert.ToInt32(NivelEducativo.Orden), RegistraInstitucion = Convert.ToBoolean(NivelEducativo.RegistraInstitucion), Sigla = NivelEducativo.Sigla } : null;
                        }
                        mapp.EducacionFormal = listEducacionFormal.OrderBy(a => a.FechaFinalizacion).ToList();

                        var queryDestrezas = _contexto.CiudadanoHabilidadDestreza.Where(a => a.CiudadanoId.Equals(mapp.Id));
                        var listDestrezas = queryDestrezas.Where(a => a.CiudadanoId == mapp.Id).ToList();
                        mapp.Destrezas = listDestrezas != null ? listDestrezas.ToList() : null;

                        var queryEducacionNoFormal = _contexto.CiudadanoEducacionNoFormal.Where(a => a.CiudadanoId.Equals(mapp.Id));
                        var listEducacionNoFormal = queryEducacionNoFormal.Where(a => a.CiudadanoId == mapp.Id).ToList();

                        List<EducacionNoFormalDTO> listEducacionNoFormalDto = await ObtenerEducacionNoFormal(listEducacionNoFormal, cancellationToken);

                        mapp.EducacionNoFormal = listEducacionNoFormalDto.OrderByDescending(a => a.FechaCertificacion).ToList();

                        var queryIdiomas = _contexto.CiudadanoIdioma.Where(a => a.CiudadanoId.Equals(mapp.Id));
                        var listIdiomas = queryIdiomas.Where(a => a.CiudadanoId == mapp.Id).ToList();

                        List<IdiomaDTO> lstIdiomaDto = ObtenerIdiomas(listIdiomas);

                        mapp.Idiomas = lstIdiomaDto.ToList();

                        if (mapp.PorcentajeHv < 100)
                        {
                            throw new Exception("Ciudadano no esta al 100% hv");
                        }
                        else
                        {
                            await _aPersona.ComplementarInfoAsync(mapp);
                            return mapp;
                        }


                    }

                    throw new Exception("Ciudadano no encontrado");
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }

            private List<IdiomaDTO> ObtenerIdiomas(List<CiudadanoIdiomaModel> listIdiomas)
            {
                List<IdiomaDTO> lstIdiomaDto = new List<IdiomaDTO>();

                foreach (var itemIdioma in listIdiomas)
                {
                    var iidioma = _contextoParametrico.idioma.Where(a => a.Id.Equals(itemIdioma.IdiomaId)).FirstOrDefault();

                    IdiomaDTO objIdioma = new()
                    {
                        IdiomaId = itemIdioma.IdiomaId,
                        Idioma = iidioma != null ? iidioma.Nombre : string.Empty,
                        NivelLectura = itemIdioma.NivelLectura,
                        NivelEscrito = itemIdioma.NivelEscrito,
                        NivelEscucha = itemIdioma.NivelEscucha,
                        NivelHablado = itemIdioma.NivelHablado
                    };

                    lstIdiomaDto.Add(objIdioma);
                }

                return lstIdiomaDto;
            }

            private async Task<List<EducacionNoFormalDTO>> ObtenerEducacionNoFormal(List<CiudadanoEducacionNoFormalModel> listEducacionNoFormal, CancellationToken cancellationToken)
            {
                List<EducacionNoFormalDTO> listEducacionNoFormalDto = new List<EducacionNoFormalDTO>();

                foreach (var itemEduc in listEducacionNoFormal)
                {
                    var queryTipoCapacitacion = _contextoParametrico.tipoCapacitacion.Where(a => a.Id.Equals(itemEduc.TipoCertificadoCapacitacionId));
                    var TipoCapacitacion = await queryTipoCapacitacion.Where(a => a.Id == itemEduc.TipoCertificadoCapacitacionId).FirstOrDefaultAsync(cancellationToken: cancellationToken);

                    var queryPaisEducNoFormal = _contextoParametrico.pais.Where(a => a.Id.Equals(itemEduc.PaisId));
                    var PaisEducNoFormal = await queryPaisEducNoFormal.Where(x => x.Id == itemEduc.PaisId).FirstOrDefaultAsync(cancellationToken: cancellationToken);

                    EducacionNoFormalDTO educacionNoFormalDTO = new()
                    {
                        Id = itemEduc.Id,
                        NombrePrograma = itemEduc.NombrePrograma,
                        Institucion = itemEduc.Institucion,
                        Duracion = itemEduc.Duracion,
                        TipoCertificadoCapacitacionId = itemEduc.TipoCertificadoCapacitacionId,
                        TipoCertificacionCapacitacion = TipoCapacitacion != null ? TipoCapacitacion.Nombre : string.Empty,
                        FechaCertificacion = itemEduc.FechaCertificacion,
                        PaisId = itemEduc.PaisId,
                        Pais = PaisEducNoFormal != null ? PaisEducNoFormal.Nombre : string.Empty
                    };

                    listEducacionNoFormalDto.Add(educacionNoFormalDTO);
                }

                return listEducacionNoFormalDto;
            }

            private List<InformacionLaboralDTO> CargaInformacionLaboral(CiudadanoVisualizacionDTO mapp, List<CiudadanoInformacionLaboralModel> listInformacionLaboral, List<CUOCDestreza> queryHabilidadLaboral, List<CUOCConocimiento> queryConocimientoLaboral)
            {
                List<InformacionLaboralDTO> listInfoLaboral = new List<InformacionLaboralDTO>();

                foreach (var empresa in listInformacionLaboral)
                {
                    InformacionLaboralDTO objinfoLaboral = new()
                    {
                        CiudadanoId = mapp.Id,
                        SectorId = empresa.SectorId,
                        OcupacionEquivalenteId = empresa.OcupacionEquivalenteId,
                        Cargo = empresa.Cargo,
                        TrabajoActual = empresa.TrabajoActual,
                        CuantasPresonasTrabajanConUsted = empresa.CuantasPresonasTrabajanConUsted,
                        FechaIngreso = empresa.FechaIngreso,
                        FechaRetiro = empresa.FechaRetiro,
                        Funciones = empresa.Funciones,
                        Id = empresa.Id,
                        NombreEmpresa = empresa.NombreEmpresa,
                        PaisId = empresa.PaisId,
                        ProductoServicioProduceComercializa = empresa.ProductoServicioProduceComercializa,
                        TelefonoEmpresa = empresa.TelefonoEmpresa,
                        TipoExperienciaId = empresa.TipoExperienciaId
                    };

                    var habilidadInfo = (from habilidades in _contexto.CiudadanoHabilidadDestrezaInformacionLaboral.Where(a => a.InformacionLaboralId.Equals(empresa.Id)).ToList()
                                         join nombreHabilidad in queryHabilidadLaboral on habilidades.HabilidadId equals nombreHabilidad.Id into joinedList
                                         from resultado in joinedList.DefaultIfEmpty()
                                         select resultado.Nombre).ToList();

                    string[] arreglohabilidad = new string[habilidadInfo.Count()];
                    for (int i = 0; i < habilidadInfo.Count; i++)
                    {
                        arreglohabilidad[i] = habilidadInfo[i];
                    }

                    objinfoLaboral.HabilidadDestrezaInformacionLaboral = arreglohabilidad;

                    var conocimientoInfo = (from conocimientos in _contexto.CiudadanoConocimientoCompetenciaInformacionLaboral.Where(a => a.InformacionLaboralId.Equals(empresa.Id)).ToList()
                                            join nombreConocimiento in queryConocimientoLaboral on conocimientos.ConocimientoId equals nombreConocimiento.Id into joinedList
                                            from resultado in joinedList.DefaultIfEmpty()
                                            select resultado.Nombre).ToList();

                    string[] arregloconocimiento = new string[conocimientoInfo.Count()];
                    for (int i = 0; i < conocimientoInfo.Count; i++)
                    {
                        arregloconocimiento[i] = conocimientoInfo[i];
                    }

                    objinfoLaboral.ConocimientoCompetenciaInformacionLaboral = arregloconocimiento;

                    listInfoLaboral.Add(objinfoLaboral);
                }

                return listInfoLaboral;
            }

            private async Task<List<string>> GetCargoNombres(List<string> cargoIneteres)
            {
                return cargoIneteres;
                //var cargoIds = ciudadanoCargoInteres.Select(ci => ci.CargoInteresId).ToList();
                /*var nombres = await _contextoParametrico.cargo
                    .Where(c => cargoIneteres.Contains(c.Id))
                    .Select(c => c.Nombre)
                    .ToListAsync();

                return nombres;*/
            }

            private async Task<List<string>> GetCondicionesDiscapacidad(List<int> condicionDiscapacidad)
            {
                var nombres = await _contextoParametrico.discapacidad
                    .Where(c => condicionDiscapacidad.Contains(c.Id))
                    .Select(c => c.Nombre)
                    .ToListAsync();

                return nombres;
            }

            /*private async Task<List<string>> GetCargoNombres(List<CiudadanoCargoInteresModel> ciudadanoCargoInteres)
            {
                var cargoIds = ciudadanoCargoInteres.Select(ci => ci.CargoInteresId).ToList();
                var nombres = await _contexto.Cargos
                    .Where(c => cargoIds.Contains(c.Id))
                    .Select(c => c.Nombre)
                    .ToListAsync();

                return nombres;
            }*/

        }
    }
}
