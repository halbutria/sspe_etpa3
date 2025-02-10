using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudDepartamentoInternacional
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int PaisInternacionalId { get; set; }
            public string Codigo { get; set; }
            public string Sigla { get; set; }
            public float Latitud { get; set; }
            public float Longitud { get; set; }
            public string Nombre { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var pais = await _contexto.PaisInternacional.FindAsync(request.PaisInternacionalId);

                var info = new Modelo.DepartamentoInternacional();
                info.PaisInternacionalId = request.PaisInternacionalId;
                info.Codigo = request.Codigo;
                info.Sigla = request.Sigla;
                info.DiviPolo = pais.Codigo + request.Codigo;
                info.Latitud = request.Latitud;
                info.Longitud = request.Longitud;
                info.Nombre = request.Nombre;

                try
                {
                    _contexto.DepartamentoInternacional.Add(info);

                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.DepartamentoInternacional, ParametricoDTO>(info);
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    throw new Exception(message);
                }


                throw new Exception("Error al guardar el departamento internacional");
            }
        }
    }
}