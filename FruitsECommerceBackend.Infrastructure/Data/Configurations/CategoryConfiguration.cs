using FruitsECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Category entity configuration.
    /// </summary>
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // configure table name.
            builder.ToTable("Categories");

            // configure key.
            builder.HasKey(c => c.Id);

            // configure property
            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasColumnType("varchar")
                .HasMaxLength(1023);
        }
    }
}
