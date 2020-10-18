using Microsoft.EntityFrameworkCore;
using backend.Models;
namespace backend.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        { }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
    }
}