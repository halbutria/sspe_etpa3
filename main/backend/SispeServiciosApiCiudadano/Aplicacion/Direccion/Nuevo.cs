using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Direccion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public Guid CiudadanoId { get; set; }
            public string? ViaPrincipalId { get; set; }
            public string? ViaPrincipalNombre { get; set; }
            public string? ViaPrincipal { get; set; }
            public string? ViaPrincipalLetraId { get; set; }
            public string? ViaPrincipalLetraNombre { get; set; }
            public string? ViaPrincipalBisId { get; set; }
            public string? ViaPrincipalBisNombre { get; set; }
            public string? ViaPrincipalSegundaLetraId { get; set; }
            public string? ViaPrincipalSegundaLetraNombre { get; set; }
            public string? ViaPrincipalCuadranteId { get; set; }
            public string? ViaPrincipalCuadranteNombre { get; set; }
            public int? ViaGeneradora { get; set; }
            public string? ViaGeneradoraLetraId { get; set; }
            public string? ViaGeneralLetraNombre { get; set; }
            public int? ViaGeneradoraPlaca { get; set; }
            public string? ViaGeneradoraCuadranteId { get; set; }
            public string? ViaGeneradoraCuadranteNombre { get; set; }
            //public List<CiudadanoDireccionComplementoModel>? Complementos { get; set; }

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
                //var direccion = _mapper.Map<Ejecuta, CiudadanoDireccionModel>(request);
                //_contexto.CiudadanoDireccion.Add(direccion);

                /*var complementos = _mapper.Map<Ejecuta, CiudadanoDireccionModel>(request);
                _contexto.CiudadanoDireccion.Add(complementos);*/
               // _contexto.CiudadanoDireccion.Add(direccion);
                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return Unit.Value; //_mapper.Map<CiudadanoDireccionModel, DireccionDTO>(direccion);//
                }
                throw new Exception("Error al gurdar la Direccion");
            }
        }
    }
}
