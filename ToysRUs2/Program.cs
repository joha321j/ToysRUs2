using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ToysRUs2.Persistency;
using ToysRUs2.Persistency.TestData;

namespace ToysRUs2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();

            SetupDbContext(host);

            host.Start();
        }
        
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        
        private static void SetupDbContext(IHost host)
        {
            IServiceScope scope = host.Services.CreateScope();

            IServiceProvider services = scope.ServiceProvider;

            try
            {
                SetupClothingContext(services.GetRequiredService<ClothesDatabaseContext>());
            }
            catch (Exception exception)
            {
                LogException(exception, services.GetRequiredService<ILogger<Program>>());
            }
        }

        private static void SetupClothingContext(ClothesDatabaseContext clothesDatabaseContext)
        {
            clothesDatabaseContext.Database.Migrate();
            clothesDatabaseContext.Database.EnsureCreated();
            TestData.Seed(clothesDatabaseContext);
        }
        
        
        private static void LogException(Exception exception, ILogger logger)
        {
            logger.LogError(exception, "An error occurred creating the DB");
            Console.WriteLine(exception.ToString());
        }
    }
}