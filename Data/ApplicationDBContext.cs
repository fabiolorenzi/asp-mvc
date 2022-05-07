using Microsoft.EntityFrameworkCore;
using tutorial.Models;

namespace tutorial.Data
{
    public class ApplicationDBContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            var ConnectionString = "server=127.0.0.1;port=3306;user=root;password=f5b23SDF121!!;database=asptutorial";
            optionsBuilder
                .UseMySql(ConnectionString, serverVersion)
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}

// "server=127.0.0.1;port=3306;user=root;password=f5b23SDF121!!;database=asptutorial"
