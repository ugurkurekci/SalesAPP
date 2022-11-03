using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sales.Api.Domain.Entity;

namespace Sales.Api.Domain.DataAccess;

public class SalesDbContext : DbContext
{

    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ProjectDbString"));
        }

    }
}