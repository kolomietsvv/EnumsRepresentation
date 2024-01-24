using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EnumsRepresentation
{
    public class PgSqlDbContext : DbContext
    {
        DbSet<Car> Cars;

        public PgSqlDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
