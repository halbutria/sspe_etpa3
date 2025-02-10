using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using static SispeServicios.Api.Parametrico.Aplicacion.Lista;

namespace SispeServicios.Api.Parametrico.Aplicacion
{
    public class Validar
    {
        public class ValidarParametrico : IRequest<bool>
        {
            public string? Tipo { get; set; }
            public string Id { get; set; }
            public string? DepartamentoId { get; set; }
        }


        public class Manejador : IRequestHandler<ValidarParametrico, bool>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<bool> Handle(ValidarParametrico request, CancellationToken cancellationToken)
            {
                bool valido = false;
                try
                {
                    ParametricoDTO outPut = new ParametricoDTO();
                    switch (request.Tipo)
                    {
                        case "TipoDocumento":
                            var tipoDocumento = await _contexto.tipoDocumento.FindAsync(int.Parse(request.Id));
                            valido = (tipoDocumento is not null)?true:false;
                            break;
                        case "Departamento":
                            var departamento = await _contexto.departamento.FindAsync(request.Id);
                            valido = (departamento is not null)?true:false;
                            break;
                        case "Municipio":
                            var municipio = await _contexto.municipio.Where(x => x.Id == request.Id && x.DepartamentoId == request.DepartamentoId).FirstOrDefaultAsync();
                            valido = (municipio is not null)? true:false;
                            break;
                        case "Pais":
                            break;
                        case "Genero":
                            break;
                        case "EstadoCivil":
                            break;
                        case "PaisNacimiento":
                            break;
                        case "DepartamentoNacimiento":
                            break;
                        case "MunicipioNacimiento":
                            break;
                        case "Eps":
                            break;
                        case "RangoSalarial":
                            break;
                        case "GrupoEtnico":
                            break;
                        case "CondicionDiscapacidad":
                            break;
                        case "CondicionSaludMental":
                            break;
                        case "CategoriaLicenciaCarro":
                            break;
                        case "CategoriaLicenciaMoto":
                            break;
                        case "SituacionLaboralActual":
                            break;
                        case "PerteneceA":
                            break;
                        case "TipoPoblacionId":
                            break;
                        default:
                            throw new Exception($"{request.Tipo} tipo no valido");
                    }

                    if(!valido)
                    {
                        throw new Exception($"{request.Id} no valido");
                    }
                    return valido;
                }
                catch (Exception)
                {
                    throw new Exception($"{request.Tipo} no encontrado");
                }

                
            }
        }

    }
}

