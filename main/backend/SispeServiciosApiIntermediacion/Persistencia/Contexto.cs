using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.DbContextBase;

namespace SispeServicios.Api.Intermediacion.Persistencia
{
    public class Contexto : ContextoBase
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreatingCustum(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<VacanteModel>().ToTable("Vacante", b => b.IsTemporal());
            //modelBuilder.Entity<VacantePrestadorAlternoModel>().ToTable("PrestadorAlterno", b => b.IsTemporal());
            //modelBuilder.Entity<VacanteIdiomaModel>().ToTable("VacanteIdioma", b => b.IsTemporal());
            //modelBuilder.Entity<VacanteMotivoExepcionalidadModel>().ToTable("VacanteMotivoExepcionalidad", b => b.IsTemporal());
            //modelBuilder.Entity<VacanteDiscapacidadModel>().ToTable("VacanteDiscapacidad", b => b.IsTemporal());
            //modelBuilder.Entity<VacanteOcupacionRelacionadaModel>().ToTable("VacanteOcupacionRelacionada", b => b.IsTemporal());
            //modelBuilder.Entity<VacanteConocimientoCompetenciaModel>().ToTable("ConocimientoCompetencia", b => b.IsTemporal());
            //modelBuilder.Entity<VacanteHabilidadDestrezaModel>().ToTable("HabilidadDestreza", b => b.IsTemporal());
        }
        public virtual DbSet<VacanteModel> Vacantes { get; set; }
        public virtual DbSet<VacantePrestadorAlternoModel>? VacantePrestadoresAlterno { get; set; }
        public virtual DbSet<VacanteIdiomaModel>? VacanteIdioma { get; set; }
        public virtual DbSet<VacanteEstadoModel>? VacanteEstado { get; set; }
        public virtual DbSet<VacanteMotivoExcepcionalidadModel>? VacanteMotivoExcepcionalidad { get; set; }
        public virtual DbSet<VacanteDenominacionRelacionadaModel>? VacanteDenominacionRelacionada { get; set; }
        public virtual DbSet<VacanteDiscapacidadModel>? VacanteDiscapacidad { get; set; }
        public virtual DbSet<VacanteConocimientoCompetenciaModel>? VacanteConocimientosCompetencia { get; set; }
        public virtual DbSet<VacanteHabilidadDestrezaModel>? VacanteHabilidadDestreza { get; set; }
        public virtual DbSet<VacanteUbicacionModel>? VacanteUbicacion { get; set; }
        public virtual DbSet<VacanteArchivoModel>? VacanteArchivo { get; set; }
        public virtual DbSet<EmpresaModel>? Empresa { get; set; }
        public virtual DbSet<EmpresaUsuarioModel>? EmpresaUsuario { get; set; }
        public virtual DbSet<EmpresaSedeModel>? EmpresaSede { get; set; }
        public virtual DbSet<EmpresaSedeUsuarioModel>? EmpresaSedeUsuario { get; set; }
        public virtual DbSet<VacanteCambioEstadoModel>? VacanteCambioEstado { get; set; }
        public virtual DbSet<VacantePoblacionVulnerableModel>? VacantePoblacionVulnerable { get; set; }
        public virtual DbSet<VacanteGrupoEtnicoModel>? VacanteGrupoEtnico { get; set; }
        public virtual DbSet<VacanteCondicionSaludMentalModel>? VacanteCondicionSaludMental { get; set; }
        public virtual DbSet<VacanteTipoPoblacionModel>? VacanteTipoPoblacion { get; set; }
        public virtual DbSet<VacanteZonaGeograficaModel>? VacanteZonaGeografica { get; set; }
       
    }
}
