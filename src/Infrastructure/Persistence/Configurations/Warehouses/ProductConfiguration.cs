using System;
using GFCA.Domain.Entities.Warehouses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Warehouses
{
    public class ProductConfiguration : EntityConfigurationAuditableBase<Product>
    {
        public override string TableName => nameof(Product);
        public override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(k => k.ProductId);

            builder.Property(p => p.ProductId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ProductCategoryId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.BrandId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.BrandCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);
            builder.Property(p => p.ProductCategoryName).HasColumnType(SqlColumnFor.Code).HasColumnOrder(5);
            builder.Property(p => p.ProductCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(6);
            builder.Property(p => p.ProductName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(7);
            builder.Property(p => p.SKU).HasColumnType(SqlColumnFor.CodeRef).HasColumnOrder(8);
            builder.Property(p => p.Color).HasColumnType(SqlColumnFor.Name).HasColumnOrder(9).IsRequired(false);
            builder.Property(p => p.Width).HasColumnType(SqlColumnFor.Mesurement).HasColumnOrder(10).IsRequired(false);
            builder.Property(p => p.Weight).HasColumnType(SqlColumnFor.Mesurement).HasColumnOrder(11).IsRequired(false);
            builder.Property(p => p.Height).HasColumnType(SqlColumnFor.Mesurement).HasColumnOrder(12).IsRequired(false);
            builder.Property(p => p.Shape).HasColumnType(SqlColumnFor.Name).HasColumnOrder(13);
            builder.Property(p => p.Size).HasColumnType(SqlColumnFor.Name).HasColumnOrder(14);
            builder.Property(p => p.QTY).HasColumnType(SqlColumnFor.Id).HasColumnOrder(15);
            builder.Property(p => p.UOM).HasColumnType(SqlColumnFor.Name).HasColumnOrder(16);
            builder.Property(p => p.LTP).HasColumnType(SqlColumnFor.Value).HasColumnOrder(17);

            builder.HasOne(d => d.ProductCategory).WithMany(m => m.Products).HasForeignKey(f => f.ProductCategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Brand).WithMany(m => m.Products).HasForeignKey(f => f.BrandId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.SaleForecasts).WithOne(o => o.Product).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
