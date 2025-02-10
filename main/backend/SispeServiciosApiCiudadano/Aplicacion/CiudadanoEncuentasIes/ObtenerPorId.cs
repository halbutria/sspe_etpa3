using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoEncuentasIes
{
    public class ObtenerPorId
    {
        public class Ejecuta : IRequest<CiudadanoEncuentasIesDTO>
        {
            public Guid CiudadanoEncuestaIesId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoEncuentasIesDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;
            private readonly ContextoParametrico _contextoParametrico;

            public Manejador(Contexto contexto, IMapper mapper, ContextoParametrico contextoParametrico)
            {
                _contexto = contexto;
                _mapper = mapper;
                _contextoParametrico = contextoParametrico;
            }

            public async Task<CiudadanoEncuentasIesDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ciudadanoEncuentasIes = await _contexto.CiudadanoEncuentasIes.Where(x => x.Id == request.CiudadanoEncuestaIesId).FirstOrDefaultAsync();

                if (ciudadanoEncuentasIes is not null)
                {
                    CiudadanoEncuentasIesDTO ciudadanoEncuentas = _mapper.Map<CiudadanoEncuentasIesModel, CiudadanoEncuentasIesDTO>(ciudadanoEncuentasIes);

                    await CompletarDatosParametrico(ciudadanoEncuentas, cancellationToken);

                    return ciudadanoEncuentas;
                }
                throw new Exception("No existe Información.");
            }

            private async Task CompletarDatosParametrico(CiudadanoEncuentasIesDTO ciudadanoEncuentas, CancellationToken cancellationToken)
            {
                ciudadanoEncuentas.TipoDocumento = await _contextoParametrico.tipoDocumento
                    .Where(td => td.Id == ciudadanoEncuentas.TipoDocumentoId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.Sexo = await _contextoParametrico.genero
                    .Where(td => td.Id == ciudadanoEncuentas.SexoId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.EstadoCivil = await _contextoParametrico.estadoCivil
                    .Where(td => td.Id == ciudadanoEncuentas.EstadoCivilId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.PaisResidencia= await _contextoParametrico.pais
                    .Where(td => td.Id == ciudadanoEncuentas.PaisResidenciaId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.DepartamentoResidencia= await _contextoParametrico.departamento
                    .Where(td => td.Id == ciudadanoEncuentas.DepartamentoResidenciaId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.MunicipioResidencia = await _contextoParametrico.municipio
                    .Where(td => td.Id == ciudadanoEncuentas.MunicipioResidenciaId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.SectorEconomico = await _contextoParametrico.sectorEconomico
                    .Where(td => td.Id == ciudadanoEncuentas.SectorEconomicoId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.TipoContrato = await _contextoParametrico.tipoContrato
                    .Where(td => td.Id == ciudadanoEncuentas.TipoContratoId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

                ciudadanoEncuentas.AreaTrabajo = await _contextoParametrico.areaEmpresa
                    .Where(td => td.Id == ciudadanoEncuentas.AreaTrabajoId)
                    .Select(td => td.Nombre)
                    .FirstOrDefaultAsync();

            }

        }
    }
}
