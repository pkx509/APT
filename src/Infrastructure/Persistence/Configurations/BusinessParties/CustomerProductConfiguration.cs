using GFCA.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.BusinessParties
{
    public class CustomerProductConfiguration : EntityConfigurationBase<CustomerProduct>
    {
        public override string TableName => nameof(CustomerProduct);

        public override void ConfigureEntity(EntityTypeBuilder<CustomerProduct> builder)
        {
            //builder.HasKey(k => k.CustomerProductId);
            builder.HasAlternateKey(a => new { a.CustomerId, a.ProductCategoryId });

            builder.Property(p => p.CustomerProductId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.CustomerId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.ProductCategoryId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);

            builder.HasOne(d => d.Customer).WithMany(m => m.CustomerProducts).HasForeignKey(f => f.CustomerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.ProductCategory).WithMany(m => m.CustomerProducts).HasForeignKey(f => f.ProductCategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }

}
