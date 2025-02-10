using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServiciosApiParametrico.Persistencia
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            var BasePath = AppContext.BaseDirectory;
            var Configuration = new ConfigurationBuilder().SetBasePath(BasePath).AddJsonFile($"appsettings.json", false).Build();
            var OptionsBuilder = new DbContextOptionsBuilder<Contexto>();
            var ConnectionString = Configuration.GetValue<string>("CbcParametrico");
            OptionsBuilder.UseSqlServer(ConnectionString);
            return new Contexto(OptionsBuilder.Options);
        }
    }
}
