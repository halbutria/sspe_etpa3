using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Experiencia;

public class Lista
{
    public class Ejecuta : IRequest<List<ExperienciaDTO>>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<ExperienciaDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<ExperienciaDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            List<ExperienciaDTO> experiencias = new List<ExperienciaDTO>();
            var info = await _contexto.CiudadanoExperiencia
                .Include(x=> x.CiudadanoEducacionFormalExperiencia)
                .Include(x=> x.ConocimientoCompetenciaExperienciaPrevia)
                .Include(x=> x.HabilidadDestrezaExperienciaPrevia)
                .Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();

            if (info.Count() > 0)
            {
                CiudadanoEducacionFormalExperienciaModel eduformal = new CiudadanoEducacionFormalExperienciaModel();

                foreach (var inf in info)
                {
                    List<string> conocimientosvr = new List<string>();
                    List<string> habilidadesvr = new List<string>();
                    //if (inf.CiudadanoEducacionFormalExperiencia is not null)
                    if (inf.CiudadanoEducacionFormalExperiencia.Count() > 0)
                        eduformal = inf.CiudadanoEducacionFormalExperiencia.First();

                    if (inf.ConocimientoCompetenciaExperienciaPrevia is not null)
                        foreach (var i in inf.ConocimientoCompetenciaExperienciaPrevia)
                            conocimientosvr.Add(i.ConocimientoId);

                    if (inf.HabilidadDestrezaExperienciaPrevia is not null)
                        foreach (var i in inf.HabilidadDestrezaExperienciaPrevia)
                            habilidadesvr.Add(i.HabilidadId);

                    experiencias.Add(
                        new ExperienciaDTO
                        {
                            Id = inf.Id,
                            CiudadanoId = inf.CiudadanoId,
                            CiudadanoEducacionFormalId = eduformal.CiudadanoEducacionFormalId,
                            Nombre = inf.Nombre,
                            Telefono = inf.Telefono,
                            TipoExperienciaId = inf.TipoExperienciaId,
                            OcupacionId = inf.OcupacionId,
                            LugarExperiencia = inf.LugarExperiencia,
                            FechaIngreso = inf.FechaIngreso,
                            FechaRetiro = inf.FechaRetiro,
                            ConocimientoCompetenciaExperienciaPrevia = conocimientosvr.ToArray(),
                            HabilidadDestrezaExperienciaPrevia = habilidadesvr.ToArray()
                        });
                }
                //
                //return _mapper.Map<List<CiudadanoExperienciaModel>, List<ExperienciaDTO>>(info);
                return experiencias;
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

