using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Migrations;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Parametrico.Modelo;

namespace SispeServicios.Api.Ciudadano.Aplicacion.NotificacionVacanteDeseada
{
    public class Edicion
    {

        public class Ejecuta : IRequest<CiudadanoNotificacionVacanteDeseadaDto>
        {
            public int Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public List<CiudadanoCriteriosNotificacionesUpdateDto> Criterios { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, CiudadanoNotificacionVacanteDeseadaDto>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<CiudadanoNotificacionVacanteDeseadaDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoNotificacionVacanteDeseada
                    .Include(c => c.Criterios)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();


                if (info is not null)
                {
                    var rmCriterios = info.Criterios
                    .Where(e => !request.Criterios.Select(p => p.Id).Contains(e.Id))
                    .ToList();
                    _contexto.CiudadanoCriteriosNotificaciones.RemoveRange(rmCriterios);


                    var updCriterios = info.Criterios.Where(e => request.Criterios.Select(p => p.Id).Contains(e.Id)).ToList();
                    foreach (var criterio in updCriterios)
                    {
                        criterio.Filtro = request.Criterios.FirstOrDefault(e => e.Id == criterio.Id).Filtro;
                        criterio.ValorId = request.Criterios.FirstOrDefault(e => e.Id == criterio.Id).ValorId;
                        criterio.Valor = request.Criterios.FirstOrDefault(e => e.Id == criterio.Id).Valor;
                    }
                    _contexto.CiudadanoCriteriosNotificaciones.UpdateRange(updCriterios);

                    var newCriteriosDto = request.Criterios.Where(e => e.Id == 0).ToList();
                    var newCriterios = new List<CiudadanoCriteriosNotificaciones>();

                    foreach (var criterioDto in newCriteriosDto)
                    {
                        var criterio = _mapper.Map<CiudadanoCriteriosNotificaciones>(criterioDto);
                        criterio.Id = 0;
                        criterio.CiudadanoNotificacionVacanteDeseadaId = info.Id;
                        criterio.Filtro = criterioDto.Filtro;
                        criterio.ValorId = criterioDto.ValorId;
                        criterio.Valor = criterioDto.Valor;

                        newCriterios.Add(criterio);
                    }
                    _contexto.CiudadanoCriteriosNotificaciones.AddRange(newCriterios);
                    


                    var respuesta = await _contexto.SaveChangesAsync();
                    //if (respuesta > 0)
                    //{
                    return _mapper.Map<CiudadanoNotificacionVacanteDeseada, CiudadanoNotificacionVacanteDeseadaDto>(info);
                    //}

                    //throw new Exception("Error al editar");
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}
