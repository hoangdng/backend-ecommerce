using FruitsECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// DeliveryAddress entity configuration.
    /// </summary>
    public class DeliveryAddressConfiguration : IEntityTypeConfiguration<DeliveryAddress>
    {
        public void Configure(EntityTypeBuilder<DeliveryAddress> builder)
        {
            // configure table name.
            builder.ToTable("DeliveryAddresses");

            // configure key.
            builder.HasKey(da => da.Id);

            // configure property
            builder.Property(da => da.Id)
                .ValueGeneratedOnAdd();

            builder.Property(da => da.Phone)
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(da => da.Address)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(da => da.City)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(da => da.District)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(da => da.Ward)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(da => da.Note)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
