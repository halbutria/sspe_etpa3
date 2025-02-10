using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPaisInternacional
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Sigla { get; set; }
            public string Nacionalidad { get; set; }

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

                var info = new Modelo.PaisInternacional();
                info.Codigo = request.Codigo;
                info.Nombre = request.Nombre;
                info.Sigla = request.Sigla;
                info.Nacionalidad = request.Nacionalidad;

                _contexto.PaisInternacional.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.PaisInternacional, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el país internacional");
            }
        }
    }
}