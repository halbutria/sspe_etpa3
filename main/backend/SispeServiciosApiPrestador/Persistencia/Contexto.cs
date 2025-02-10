using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.DbContextBase;

namespace SispeServicios.Api.Prestador.Persistencia
{
    public class Contexto : ContextoBase
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreatingCustum(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrestadorModel>().ToTable("Prestador", b => b.IsTemporal());
            modelBuilder.Entity<PuntoAtencionModel>().ToTable("PuntoAtencion", b => b.IsTemporal());
        }

        public virtual DbSet<PrestadorModel>? Prestador { get; set; }
        public virtual DbSet<PuntoAtencionModel>? PuntoAtencion { get; set; }
    }
}
