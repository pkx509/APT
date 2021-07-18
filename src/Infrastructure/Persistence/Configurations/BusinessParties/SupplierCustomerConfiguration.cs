using System;
using GFCA.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.BusinessParties
{
    public class SupplierCustomerConfiguration : EntityConfigurationAuditableBase<SupplierCustomer>
    {

        public override string TableName => nameof(SupplierCustomer);
        public override void ConfigureEntity(EntityTypeBuilder<SupplierCustomer> builder)
        {
            builder.HasKey(k => k.SupplierCustomerId);
            //builder.HasAlternateKey(k => new { k.SupplierId, k.BrandId, k.CustomerId, k.ChannelId });

            builder.Property(p => p.SupplierCustomerId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.SupplierId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2).IsRequired(false);
            builder.Property(p => p.BrandId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3).IsRequired(false);
            builder.Property(p => p.CustomerId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(4).IsRequired(false);
            builder.Property(p => p.ChannelId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(5).IsRequired(false);
            builder.Property(p => p.IsActive).HasColumnType(SqlColumnFor.Id).HasColumnOrder(6);

            builder.HasOne(o => o.Supplier).WithMany(o => o.SupplierCustomers).HasForeignKey(f => f.SupplierId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(o => o.Brand).WithMany(o => o.SupplierCustomers).HasForeignKey(f => f.BrandId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(o => o.Customer).WithMany(o => o.SupplierCustomers).HasForeignKey(f => f.CustomerId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(o => o.Channel).WithMany(o => o.SupplierCustomers).HasForeignKey(f => f.ChannelId).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
