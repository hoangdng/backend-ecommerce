using FruitsECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// ShoppingSession entity configuration.
    /// </summary>
    public class ShoppingSessionConfiguration : IEntityTypeConfiguration<ShoppingSession>
    {
        public void Configure(EntityTypeBuilder<ShoppingSession> builder)
        {
            // configure table name.
            builder.ToTable("ShoppingSessions");

            // configure key.
            builder.HasKey(ss => ss.Id);

            // configure property
            builder.Property(ss => ss.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ss => ss.TotalQuantity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(ss => ss.TotalPrice)
               .HasColumnType("money")
               .IsRequired();

            // configure one-to-many relationship
            builder.HasMany(ss => ss.CartItems)
                .WithOne(ci => ci.ShoppingSession)
                .HasForeignKey(ci => ci.ShoppingSessionId);
        }
    }
}
