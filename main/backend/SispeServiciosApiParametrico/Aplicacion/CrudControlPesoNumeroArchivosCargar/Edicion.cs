using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudControlPesoNumeroArchivosCargar
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; } = null!;
            public int cantidadAdjuntosHv { get; set; }
            public int pesoMaximoArchivoAdjuntoHv { get; set; }
            public int cantidadAdjuntosInformacionAcademica { get; set; }
            public int pesoMaximoArchivoAdjuntoInformacionAcademica { get; set; }
            public int cantidadAdjuntosInformacionLaboral { get; set; }
            public int pesoMaximoArchivoAdjuntoInformacionLaboral { get; set; }
            public int cantidadAdjuntosEducacionInformal { get; set; }
            public int pesoMaximoArchivoAdjuntoEducacionInformal { get; set; }
            public int cantidadAdjuntosIdiomas { get; set; }
            public int pesoMaximoArchivoAdjuntoIdiomas { get; set; }
            public int pesoMaximoArchivoAdjuntoFoto { get; set; }
            public int cantidadEnlacesPermitidos { get; set; }
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
                var info = await _contexto.ControlPesoNumeroArchivosCargar.FindAsync(Int32.Parse(request.Id));

                if (info is not null)
                {
                    _mapper.Map(request, info, typeof(Ejecuta), typeof(ControlPesoNumeroArchivosCargar));

                    _contexto.ControlPesoNumeroArchivosCargar.Update(info);

                    await _contexto.SaveChangesAsync();
                    return _mapper.Map<ControlPesoNumeroArchivosCargar, ParametricoDTO>(info);
           
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}
