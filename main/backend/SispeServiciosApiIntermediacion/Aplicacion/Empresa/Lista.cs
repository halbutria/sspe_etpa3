using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Paginacion;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Empresa
{
    public class Lista
    {
        
        public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<EmpresaDTO> data)>
        {
        }

        public class Manejador : IRequestHandler<Ejecuta, (string encabezado, List<EmpresaDTO> data)>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<(string encabezado, List<EmpresaDTO> data)> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var query = _contexto.Empresa;

                var info = await ListaPaginada<EmpresaModel>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);

                if (info is not null)
                {
                    return (info.GetMetadata(), _mapper.Map<List<EmpresaModel>, List<EmpresaDTO>>(info));
                }
                throw new Exception("No existe Información.");
            }
        }

    }
}
