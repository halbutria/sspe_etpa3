using MediatR;
using AutoMapper;
using SispeServiciosApiCiudadano.DTOs;
using SispeServiciosApiCiudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoServiciosEspeciales
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<CiudadanoServiciosEspecialesDTO>
        {
            public CiudadanoServiciosEspecialesDTO CiudadanoServiciosEspeciales { get; set; } = new CiudadanoServiciosEspecialesDTO();
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoServiciosEspecialesDTO>
        {

            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<CiudadanoServiciosEspecialesDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoServiciosEspecialesModel? CiudadanoServiciosEspeciales = await _contexto.CiudadanoServiciosEspeciales.Where(x => x.CiudadanoId == request.CiudadanoServiciosEspeciales.CiudadanoId
                                                                                                 && x.CodigoTipoServicio == request.CiudadanoServiciosEspeciales.CodigoTipoServicio
                                                                                                 && x.TipoServicio == request.CiudadanoServiciosEspeciales.TipoServicio)
                                                                                          .FirstOrDefaultAsync();
                if (CiudadanoServiciosEspeciales is not null)
                {
                    _contexto.CiudadanoServiciosEspeciales.Update(CiudadanoServiciosEspeciales);
                }
                else
                {
                    CiudadanoServiciosEspeciales = _mapper.Map<CiudadanoServiciosEspecialesDTO, CiudadanoServiciosEspecialesModel>(request.CiudadanoServiciosEspeciales);
                    await _contexto.CiudadanoServiciosEspeciales.AddAsync(CiudadanoServiciosEspeciales);
                }
                
                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    var resp = _mapper.Map<CiudadanoServiciosEspecialesModel, CiudadanoServiciosEspecialesDTO>(CiudadanoServiciosEspeciales);
                    return resp;
                }

                throw new Exception("Error al gurdar barrera de empleo");
            }
        }
    }
}
