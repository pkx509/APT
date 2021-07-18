using System;
using GFCA.Domain.Entities.BusinessParties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.BusinessParties
{
    public class SupplierConfiguration : EntityConfigurationAuditableBase<Supplier>
    {
        public override string TableName => nameof(Supplier);

        public override void ConfigureEntity(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(k => k.SupplierId);
            //builder.HasAlternateKey(a => new { a.CustomerId, a.BrandId, a.ClientCode });

            builder.Property(p => p.SupplierId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.SupplierCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.SupplierName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);

            builder.HasMany(m => m.SupplierCustomers).WithOne(o => o.Supplier).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.Documents).WithOne(o => o.Supplier).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
