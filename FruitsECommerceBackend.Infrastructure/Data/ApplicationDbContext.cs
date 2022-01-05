using FruitsECommerceBackend.Domain.Entities;
using FruitsECommerceBackend.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FruitsECommerceBackend.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionOptions"></param>
        public ApplicationDbContext(IOptions<DbSettings> connectionOptions) : base(GetDbContextOptions(connectionOptions.Value)) { }


        /// <summary>
        /// Get database context options
        /// </summary>
        /// <param name="dbSettings"></param>
        /// <returns></returns>
        private static DbContextOptions GetDbContextOptions(DbSettings dbSettings)
        {
            if (dbSettings.UseInMemory)
            {
                return new DbContextOptionsBuilder().UseInMemoryDatabase(dbSettings.DbName).Options;
            }
            else
            {
                return SqlServerDbContextOptionsExtensions.UseSqlServer(
                    new DbContextOptionsBuilder(),
                    dbSettings.ConnectionString,
                    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                ).Options;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure default schema
            modelBuilder.HasDefaultSchema("FruitsECommerce");

            // Use entities configurations
            modelBuilder.ApplyConfiguration(new CartItemConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryAddressConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingSessionConfiguration());
        }

        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingSession> ShoppingSessions { get; set; }
    }
}
