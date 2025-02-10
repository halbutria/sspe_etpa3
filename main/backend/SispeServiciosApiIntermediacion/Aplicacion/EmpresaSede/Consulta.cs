using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;

namespace SispeServicios.Api.Intermediacion.Aplicacion.EmpresaSede
{
    public class Consulta
    {

        public class Ejecuta: IRequest<EmpresaSedeDetalleDTO>
        {
            public int Id { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, EmpresaSedeDetalleDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<EmpresaSedeDetalleDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.EmpresaSede
                    .Include("Usuarios.EmpresaUsuario")
                    .Include(x=>x.Empresa)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();


                if (info is not null)
                {
                    return _mapper.Map<EmpresaSedeModel, EmpresaSedeDetalleDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }

    }
}
