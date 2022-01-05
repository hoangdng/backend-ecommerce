using FruitsECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FruitsECommerceBackend.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Product entity configuration.
    /// </summary>
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // configure table name.
            builder.ToTable("Products");

            // configure key.
            builder.HasKey(p => p.Id);

            // configure property
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.Description)
               .HasColumnType("varchar")
               .HasMaxLength(1023)
               .IsRequired();

            builder.Property(p => p.Price)
              .HasColumnType("money")
              .IsRequired();

            builder.Property(p => p.Quantity)
              .HasColumnType("int")
              .IsRequired();

            // configure many-to-many relationship
            builder.HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductCategories",
                     pc => pc.HasOne<Category>()
                            .WithMany()
                            .HasForeignKey("CategoryId")
                            .HasConstraintName("FK_ProductCategories_Categories_CategoryId"),
                    pc => pc.HasOne<Product>()
                            .WithMany()
                            .HasForeignKey("ProductId")
                            .HasConstraintName("FK_ProductCategories_Products_ProductId")
                );
        }
    }
}
