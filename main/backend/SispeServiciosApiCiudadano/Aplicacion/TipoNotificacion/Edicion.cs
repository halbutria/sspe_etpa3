using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.TipoNotificacion
{
    public class Edicion
    {
        public class Ejecuta : IRequest
        {
            public Guid CiudadanoId { get; set; }
            public int[] TipoNotificacion { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var infoCiudadano = await _contexto.Ciudadano.Include(i=>i.TipoNotificacion).Where(x => x.Id == request.CiudadanoId).FirstOrDefaultAsync();
                    if (infoCiudadano != null)
                    {
                        var info = infoCiudadano.TipoNotificacion;

                        ICollection<CiudadanoTipoNotificacionModel> tipoNotificaicon = new List<CiudadanoTipoNotificacionModel>();
                        foreach (var id in request.TipoNotificacion)
                        {
                            tipoNotificaicon.Add(new CiudadanoTipoNotificacionModel { tipoNotificacionId = id, CiudadanoId = request.CiudadanoId });
                        }
                        if (info?.Count() > 0)
                        {
                            _contexto.RemoveRange(info);
                        }

                        _contexto.CiudadanoTipoNotificacion.AddRange(tipoNotificaicon);
                        await _contexto.SaveChangesAsync();
                        return Unit.Value;
                    }
                    throw new Exception("Error Actualizar");
                }
                catch (Exception)
                {

                    throw new Exception("Error Actualizar");
                }
                
            }

            
        }
    }
}
//List<TipoNotificacionDTO>