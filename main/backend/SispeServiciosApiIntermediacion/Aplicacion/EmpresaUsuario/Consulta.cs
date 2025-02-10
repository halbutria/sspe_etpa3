using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;

namespace SispeServicios.Api.Intermediacion.Aplicacion.EmpresaUsuario
{
    public class Consulta
    {

        public class Ejecuta : IRequest<EmpresaUsuarioDTO>
        {
            public Guid? Id { get; set; }
            public int? TipoDocumentoId { get; set; }
            public string? NumeroDocumento { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, EmpresaUsuarioDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<EmpresaUsuarioDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var query = _contexto.EmpresaUsuario
                //    .AsQueryable();
                //if (request.Id is not null)
                //{
                //    query = query.Where(x => x.Id == request.Id);
                //}
                //else if (request.TipoDocumentoId is not null && request.NumeroDocumento is not null)
                //{
                //    query = query.Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento);
                //}
                //else
                //{
                //    throw new Exception("No existe Información.");
                //}
                //var info = await query.FirstOrDefaultAsync();
                //if (info is not null)
                //{
                //    return _mapper.Map<EmpresaUsuarioModel, EmpresaResponsableDTO>(info);
                //}
                throw new Exception("No existe Información.");
            }
        }


    }
}
