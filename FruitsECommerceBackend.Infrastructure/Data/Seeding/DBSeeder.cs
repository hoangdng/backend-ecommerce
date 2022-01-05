using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding
{
    public static class DBSeeder
    {
        /// <summary>
        /// Initialize in memory database with seeding data
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                // Insert seed data into the database using one instance of the context
                using var context = new ApplicationDbContext(serviceProvider.GetService<IOptions<DbSettings>>());
                Seed(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Seed data.
        /// </summary>
        /// <param name="context"></param>
        private static void Seed(ApplicationDbContext context)
        {
            if (context == null)
                return;

            // Create database if it does not already exist.
            // Run Database Migration when Database ProviderName is not InMemory.
            if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
            {
                context.Database.Migrate();
                Console.WriteLine("Using local database!");
            }
            else
            {
                Console.WriteLine("Using in-memory database!");
            }

            // seed data if there are no records in the database
            //if (!context.Trackings.Any())
            //{
            //    const int NUMBER_OF_RECORDS = 10;

            //    TrackingFaker trackingFaker = new TrackingFaker();
            //    List<TrackingModel> listFakeTrackings = trackingFaker.Generate(NUMBER_OF_RECORDS);

            //    context.Trackings.AddRange(listFakeTrackings);
            //    context.SaveChanges();
            //}
        }
    }
}
