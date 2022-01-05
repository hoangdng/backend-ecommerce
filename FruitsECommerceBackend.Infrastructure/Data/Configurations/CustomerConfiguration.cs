using FruitsECommerceBackend.Domain.Entities;
using FruitsECommerceBackend.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Customer entity configuration.
    /// </summary>
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // configure table name.
            builder.ToTable("Customers");

            // configure key.
            builder.HasKey(c => c.Id);

            // configure property
            builder.Property(c => c.Id)
               .ValueGeneratedOnAdd();

            builder.Property(c => c.Username)
                .HasColumnType("varchar")
                .HasMaxLength(255);
            builder.HasIndex(c => new { c.Username })
                .IsUnique();

            builder.Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            builder.Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(255);
            builder.HasIndex(c => new { c.Email })
               .IsUnique();

            builder.Property(c => c.Level)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .HasConversion(
                    l => l.ToString(),
                    l => (MemberLevel)Enum.Parse(typeof(MemberLevel), l));

            // configure one-to-many relationships
            builder.HasMany(c => c.DeliveryAddresses)
                .WithOne(da => da.Customer)
                .HasForeignKey(da => da.CustomerId);

            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            // configure one-to-one relationship
            builder.HasOne(c => c.ShoppingSession)
                .WithOne(ss => ss.Customer)
                .HasForeignKey<Customer>(c => c.ShoppingSessionId);
        }
    }
}
