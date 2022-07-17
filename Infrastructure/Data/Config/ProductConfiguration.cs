using ApplicationCore.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
               .IsRequired(true)
               .HasMaxLength(50);

            builder.Property(p => p.Price)
                .IsRequired(true)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.PictureUri)
                .IsRequired(false);

            builder.HasOne(p => p.ProductBrand)
                .WithMany()
                .HasForeignKey(p => p.ProductBrandId);

            builder.HasOne(p => p.ProductType)
                .WithMany()
                .HasForeignKey(p => p.ProductTypeId);
        }
    }
}
