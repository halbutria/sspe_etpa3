using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SispeServicios.Api.Ciudadano.Persistencia
{
    /// <summary>
    /// <see cref="ContextoFactory"/>
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory&lt;SispeServicios.Api.Ciudadano.Persistencia.Contexto&gt;" />
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        /// <summary>
        /// Creates a new instance of a derived context.
        /// </summary>
        /// <param name="args">Arguments provided by the design-time service.</param>
        /// <returns>
        /// An instance of <typeparamref name="TContext" />.
        /// </returns>
        public Contexto CreateDbContext(string[] args)
        {
            var BasePath = AppContext.BaseDirectory;
            var Configuration = new ConfigurationBuilder().SetBasePath(BasePath).AddJsonFile($"appsettings.json", false).Build();
            var OptionsBuilder = new DbContextOptionsBuilder<Contexto>();
            //var ConnectionString = Configuration.GetConnectionString("CbcCiudadano");
            var ConnectionString = Configuration.GetValue<string>("CbcCiudadano");
            OptionsBuilder.UseSqlServer(ConnectionString);
            return new Contexto(OptionsBuilder.Options);
        }
    }
}
