using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Migrations;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Direccion
{
    public class Edicion
    {

        public class Ejecuta : IRequest
        {
            public Guid Id { get; set; }
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
                //var info = await _contexto.CiudadanoDireccion.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                ////var info = null;
                //if (info is not null)
                //{

                //    info.ViaPrincipalId = request.ViaPrincipalId;
                //    info.ViaPrincipalNombre = request.ViaPrincipalNombre;
                //    info.ViaPrincipal = request.ViaPrincipal;
                //    info.ViaPrincipalLetraId = request.ViaPrincipalLetraId;
                //    info.ViaPrincipalLetraNombre = request.ViaPrincipalLetraNombre;
                //    info.ViaPrincipalBisId = request.ViaPrincipalBisId;
                //    info.ViaPrincipalBisNombre = request.ViaPrincipalBisNombre;
                //    info.ViaPrincipalSegundaLetraId = request.ViaPrincipalSegundaLetraId;
                //    info.ViaPrincipalSegundaLetraNombre = request.ViaPrincipalSegundaLetraNombre;
                //    info.ViaPrincipalCuadranteId = request.ViaPrincipalCuadranteId;
                //    info.ViaPrincipalCuadranteNombre = request.ViaPrincipalCuadranteNombre;
                //    info.ViaGeneradora = request.ViaGeneradora;
                //    info.ViaGeneradoraLetraId = request.ViaGeneradoraLetraId;
                //    info.ViaGeneralLetraNombre = request.ViaGeneralLetraNombre;
                //    info.ViaGeneradoraPlaca = request.ViaGeneradoraPlaca;
                //    info.ViaGeneradoraCuadranteId = request.ViaGeneradoraCuadranteId;
                //    info.ViaGeneradoraCuadranteNombre = request.ViaGeneradoraCuadranteNombre;

                //    var respuesta = await _contexto.SaveChangesAsync();
                //    if (respuesta > 0)
                //    {
                //        return Unit.Value;//_mapper.Map<CiudadanoEducacionFormal, EducacionFormalDTO>(info);
                //    }

                //    throw new Exception("Error al editar");
                //}
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}

