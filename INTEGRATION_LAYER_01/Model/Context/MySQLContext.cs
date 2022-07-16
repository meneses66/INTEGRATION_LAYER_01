using Microsoft.EntityFrameworkCore;

namespace INTEGRATION_LAYER_01.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Sdev> SDevs { get; set; }

        public DbSet<Raca> Racas { get; set; }

    }
}
