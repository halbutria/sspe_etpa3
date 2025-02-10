using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudMunicipioInternacional
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int DepartamentoInternacionalId { get; set; }
            public string Tipo { get; set; }
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
                var dep = await _contexto.DepartamentoInternacional
                    .Where(d => d.Id == request.DepartamentoInternacionalId && !d.Eliminado)
                    .FirstOrDefaultAsync();

                var info = new Modelo.MunicipioInternacional();
                info.DepartamentoInternacionalId = request.DepartamentoInternacionalId;
                info.Tipo = request.Tipo;
                info.Codigo = request.Codigo;
                info.Sigla = request.Sigla;
                info.DiviPolo = dep.DiviPolo + request.Codigo;
                info.Latitud = request.Latitud;
                info.Longitud = request.Longitud;
                info.Nombre = request.Nombre;

                try
                {
                    _contexto.MunicipioInternacional.Add(info);

                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.MunicipioInternacional, ParametricoDTO>(info);
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    throw new Exception(message);
                }


                throw new Exception("Error al guardar el municipio internacional");
            }
        }
    }
}