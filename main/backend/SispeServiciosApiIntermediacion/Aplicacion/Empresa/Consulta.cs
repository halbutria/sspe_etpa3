using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Empresa
{
    public class Consulta
    {
        public class Ejecuta : IRequest<EmpresaDetalleDTO>
        {
            public int? Id { get; set; }
            public int? TipoDocumentoId { get; set; }
            public string? NumeroDocumento { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, EmpresaDetalleDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<EmpresaDetalleDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var query = _contexto.Empresa
                    .Include("Sedes.Usuarios.EmpresaUsuario")
                    .AsQueryable();
                if(request.Id is not null)
                {
                    query = query.Where(x => x.Id == request.Id);
                }
                else if(request.TipoDocumentoId is not null && request.NumeroDocumento is not null)
                {
                    query = query.Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento);
                }
                else
                {
                    throw new Exception("No existe Información.");
                }
                var info = await query.FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<EmpresaModel, EmpresaDetalleDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
