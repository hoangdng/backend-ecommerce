using FruitsECommerceBackend.Domain.Entities;
using FruitsECommerceBackend.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Order entity configuration.
    /// </summary>
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // configure table name.
            builder.ToTable("Orders");

            // configure key.
            builder.HasKey(o => o.Id);

            // configure property
            builder.Property(o => o.Id)
                .ValueGeneratedOnAdd();

            builder.Property(o => o.TotalQuantity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(o => o.TotalPrice)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(o => o.CreatedAt)
                .HasDefaultValueSql("getutcdate()")
                .IsRequired();

            builder.Property(o => o.State)
               .HasColumnType("varchar")
               .HasMaxLength(255)
               .HasConversion(
                   s => s.ToString(),
                   s => (OrderState)Enum.Parse(typeof(OrderState), s));

            // configure one-to-many relationship
            builder.HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);
        }
    }
}
