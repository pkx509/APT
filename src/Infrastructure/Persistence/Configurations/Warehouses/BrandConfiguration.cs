using System;
using GFCA.Domain.Entities.Warehouses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Warehouses
{
    public class BrandConfiguration : EntityConfigurationAuditableBase<Brand>
    {
        public override string TableName => nameof(Brand);

        public override void ConfigureEntity(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(k => k.BrandId);

            builder.Property(p => p.BrandId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.BrandCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.BrandName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);

            builder.HasMany(m => m.Products).WithOne(o => o.Brand).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.SupplierCustomers).WithOne(o => o.Brand).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.SaleForecasts).WithOne(o => o.Brand).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.FixedContracts).WithOne(o => o.Brand).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.Budgets).WithOne(o => o.Brand).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
