using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCamposCreacionEmpresaExtrangera
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int TipoPersona { get; set; }
            public int TipoDocumento { get; set; }
            public int Naturaleza { get; set; }
            public int TipoEmpresa { get; set; }
            public int TamanioPorNumeroEmpleados { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                CamposCreacionEmpresaExtrangera info = new Modelo.CamposCreacionEmpresaExtrangera();
                info.TipoPersona = request.TipoPersona;
                info.TipoDocumento = request.TipoDocumento;
                info.Naturaleza = request.Naturaleza;
                info.Tipo = request.TipoEmpresa;
                info.TamanioPorNumeroEmpleados = request.TamanioPorNumeroEmpleados;

                _contexto.CamposCreacionEmpresaExtrangera.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.CamposCreacionEmpresaExtrangera, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el campo de salida plan de mejoramiento");
            }
        }
    }
}
