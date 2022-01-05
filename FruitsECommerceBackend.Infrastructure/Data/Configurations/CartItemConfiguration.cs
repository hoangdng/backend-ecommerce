using FruitsECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// CartItem configuration.
    /// </summary>
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            // configure table name.
            builder.ToTable("CartItems");

            // configure key.
            builder.HasKey(ci => ci.Id);

            // configure property
            builder.Property(ci => ci.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ci => ci.Quantity)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
