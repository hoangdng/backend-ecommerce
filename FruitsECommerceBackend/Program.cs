using FruitsECommerceBackend.Infrastructure.Data.Seeding;

namespace FruitsECommerceBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                // get the instance of DbContext in our services layer.
                var services = scope.ServiceProvider;

                // TODO: Call the Seeder to seed sample data.
                DBSeeder.Initialize(services);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
