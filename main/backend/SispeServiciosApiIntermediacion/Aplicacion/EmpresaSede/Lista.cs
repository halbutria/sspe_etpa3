using AutoMapper;
using MediatR;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Paginacion;

namespace SispeServicios.Api.Intermediacion.Aplicacion.EmpresaSede
{
    public class Lista
    {

        public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<EmpresaSedeDTO> data)>
        {
            public int EmpresaId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, (string encabezado, List<EmpresaSedeDTO> data)>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<(string encabezado, List<EmpresaSedeDTO> data)> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var query = _contexto.EmpresaSede?.Where(x=>x.EmpresaId == request.EmpresaId);

                //var info = await ListaPaginada<EmpresaSedeModel>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);

                //if (info is not null)
                //{
                //    return (info.GetMetadata(), _mapper.Map<List<EmpresaSedeModel>, List<EmpresaSedeDTO>>(info));
                //}
                throw new Exception("No existe Información.");
            }
        }

    }
}
