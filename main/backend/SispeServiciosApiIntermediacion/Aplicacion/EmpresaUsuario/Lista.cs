using AutoMapper;
using MediatR;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Paginacion;

namespace SispeServicios.Api.Intermediacion.Aplicacion.EmpresaUsuario
{
    public class Lista
    {

        public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<EmpresaUsuarioDTO> data)>
        {
            public int EmpresaId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, (string encabezado, List<EmpresaUsuarioDTO> data)>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<(string encabezado, List<EmpresaUsuarioDTO> data)> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var query = _contexto.EmpresaUsuario?.Where(x=>x.EmpresaId == request.EmpresaId);

                //var info = await ListaPaginada<EmpresaUsuarioModel>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);

                //if (info is not null)
                //{
                //    return (info.GetMetadata(), _mapper.Map<List<EmpresaUsuarioModel>, List<EmpresaResponsableDTO>>(info));
                //}
                throw new Exception("No existe Información.");
            }
        }

    }
}
