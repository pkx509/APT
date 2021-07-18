using System;
using GFCA.Domain.Entities.Warehouses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Warehouses
{
    public class ProductCategoryConfiguration : EntityConfigurationBase<ProductCategory>
    {
        public override string TableName => nameof(ProductCategory);
        public override void ConfigureEntity(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(k => k.ProductCategoryId);

            builder.Property(p => p.ProductCategoryId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ProductCategoryName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(2);

        }
    }
}
