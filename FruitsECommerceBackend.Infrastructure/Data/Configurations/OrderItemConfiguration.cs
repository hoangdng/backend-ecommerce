using FruitsECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// OrderItem entity configuration.
    /// </summary>
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            // configure table name.
            builder.ToTable("OrderItems");

            // configure key.
            builder.HasKey(oi => oi.Id );

            // configure property
            builder.Property(oi => oi.Id)
                .ValueGeneratedOnAdd();

            builder.Property(oi => oi.Quantity)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
