using API.Paises.Entidades;
using Microsoft.EntityFrameworkCore;

namespace API.Paises.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estados { get; set; }
    }
}
