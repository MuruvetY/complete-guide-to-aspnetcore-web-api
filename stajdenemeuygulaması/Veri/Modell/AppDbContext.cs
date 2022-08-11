using Microsoft.EntityFrameworkCore;

namespace stajdenemeuygulaması.Veri.Modell
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Sinif> Sinif { get; set; }
    }
}
