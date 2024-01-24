using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EnumsRepresentation
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<PgSqlDbContext>
    {
        public PgSqlDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                    .AddInMemoryCollection(new[] {
                        new KeyValuePair<string, string>("ConnectionStrings:DefaultConnection", "Host=localhost;Port=5432; Database=EnumsRepresentation; Username=postgres; Password=1")
                    })
                    .Build();

            var optionsBuilder = new DbContextOptionsBuilder();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString);

            return new PgSqlDbContext(optionsBuilder.Options);
        }
    }
}
