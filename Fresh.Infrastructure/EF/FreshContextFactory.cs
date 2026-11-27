using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Fresh.Infrastructure.EF;

public class FreshContextFactory : IDesignTimeDbContextFactory<FreshContext>
{
    public FreshContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<FreshContext>();

        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Fresh.WebAPI"))
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString =
            config.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string not found.");

        optionsBuilder.UseSqlServer(connectionString);

        return new FreshContext(optionsBuilder.Options);
    }
}