using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudMunicipioInternacional
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; }
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
                var info = await _contexto.MunicipioInternacional.FindAsync(Int32.Parse(request.Id));

                if (info is not null)
                {
                    try
                    {
                        _mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.MunicipioInternacional));
                        
                        var dep = await _contexto.DepartamentoInternacional.FindAsync(request.DepartamentoInternacionalId);
                       
                        info.DiviPolo = dep.DiviPolo + request.Codigo;
                        _contexto.MunicipioInternacional.Update(info);

                        await _contexto.SaveChangesAsync();

                        return _mapper.Map<Modelo.MunicipioInternacional, ParametricoDTO>(info);
                    }
                    catch (Exception ex)
                    {
                        var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                        throw new Exception(message);
                    }

                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}