using Microsoft.EntityFrameworkCore;
using SispeServicios.DbContextBase.Modelo;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace SispeServicios.DbContextBase
{
    public partial class ContextoBase : DbContext
    {
        public ContextoBase(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingCustum(modelBuilder);
            modelBuilder.ApplySoftDeleteQueryFilter();
        }


        protected internal virtual void OnModelCreatingCustum(ModelBuilder modelBuilder)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcesarSalvado();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ProcesarSalvado()
        {
            DateTimeOffset horaActual = DateTimeOffset.UtcNow;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is EntidadBase))
            {
                var entidad = item.Entity as EntidadBase;
                entidad.FechaCreacion = horaActual;
                entidad.UsuarioCreacion = "";//servicioUsuarioActual.ObtenerNombreUsuarioActual();
                entidad.FechaModificacion = horaActual;
                entidad.UsuarioModificacion = "";//servicioUsuarioActual.ObtenerNombreUsuarioActual();
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified && e.Entity is EntidadBase))
            {
                var entidad = item.Entity as EntidadBase;
                entidad.FechaModificacion = horaActual;
                entidad.UsuarioModificacion = "";//servicioUsuarioActual.ObtenerNombreUsuarioActual();
                item.Property(nameof(entidad.FechaCreacion)).IsModified = false;
                item.Property(nameof(entidad.UsuarioCreacion)).IsModified = false;
            }

            foreach (var item in ChangeTracker.Entries()
               .Where(e => e.State == EntityState.Deleted && e.Entity is EntidadBase))
            {
                var entidad = item.Entity as EntidadBase;
                entidad.Eliminado = true;
                entidad.FechaModificacion = horaActual;
                entidad.UsuarioModificacion = "";//servicioUsuarioActual.ObtenerNombreUsuarioActual();
                item.Property(nameof(entidad.FechaCreacion)).IsModified = false;
                item.Property(nameof(entidad.UsuarioCreacion)).IsModified = false;
                item.State = EntityState.Modified;
            }
        }
    }


    internal static class SoftDeleteModelBuilderExtensions
    {
        public static ModelBuilder ApplySoftDeleteQueryFilter(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (!typeof(EntidadBase).IsAssignableFrom(entityType.ClrType))
                {
                    continue;
                }

                var param = Expression.Parameter(entityType.ClrType, "entity");
                var prop = Expression.PropertyOrField(param, nameof(EntidadBase.Eliminado));
                var entityNotDeleted = Expression.Lambda(Expression.Equal(prop, Expression.Constant(false)), param);

                entityType.SetQueryFilter(entityNotDeleted);
            }

            return modelBuilder;
        }
    }
}