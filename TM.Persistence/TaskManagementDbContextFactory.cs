using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TM.Persistence
{
    public class TMDbContextFactory : IDesignTimeDbContextFactory<TMDbContext>
    {
        public TMDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory() + "/../TM.API")
                 .AddJsonFile("appsettings.json")
                 .Build();

            var builder = new DbContextOptionsBuilder<TMDbContext>();
            var connectionString = configuration.GetConnectionString("TMConnectionString");

            builder.UseNpgsql(connectionString);

            return new TMDbContext(builder.Options);
        }
    }
}
