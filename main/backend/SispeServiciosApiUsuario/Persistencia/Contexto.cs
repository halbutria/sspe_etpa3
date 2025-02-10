using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SispeServicios.Api.Usuario.Persistencia
{
    public class Contexto: IdentityDbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
    }
}
