using Ecommerce.Api.src.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ecommerce.Api.src.Mappings;
public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
        .ToTable("products");
        builder
        .HasKey(x => x.Id);
        builder
        .Property(x => x.Id)
        .ValueGeneratedOnAdd();
        builder
        .Property(x => x.Name)
        .HasMaxLength(255)
        .IsRequired();
        builder
        .Property(x => x.Description)
        .HasMaxLength(255)
        .IsRequired();
        builder
        .Property(x => x.Price);
        builder
        .Property(x => x.ImageUrl)
        .HasMaxLength(255)
        .IsRequired();
        builder
        .Property(x => x.Unit)
        .HasMaxLength(255)
        .IsRequired();
        builder
        .Property(x => x.Quantity);
        builder
        .Property(x => x.Tags)
        .HasMaxLength(255)
        .IsRequired();
        builder
        .Property(x => x.CategoryId)
        .HasMaxLength(255)
        .IsRequired();
        builder
        .HasOne(x => x.Category)
        .WithMany()
        .HasForeignKey(x => x.CategoryId)
        .IsRequired();

    }
}
