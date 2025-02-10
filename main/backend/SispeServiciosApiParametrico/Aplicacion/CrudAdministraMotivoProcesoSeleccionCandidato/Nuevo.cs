using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudAdministraMotivoProcesoSeleccionCandidato
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Nombre { get; set; }
            public string? Descripcion { get; set; }

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
                
                var info = new Modelo.AdministraMotivoProcesoSeleccionCandidato();
                info.Nombre = request.Nombre;
                info.Descripcion = request.Descripcion;

                _contexto.AdministraMotivoProcesoSeleccionCandidatos.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.AdministraMotivoProcesoSeleccionCandidato, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar la administración del motivo de proceso de selección del candidato");
            }
        }
    }
}
