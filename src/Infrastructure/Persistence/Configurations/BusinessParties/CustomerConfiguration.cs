using System;
using GFCA.Domain.Entities.BusinessParties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.BusinessParties
{
    public class CustomerConfiguration : EntityConfigurationAuditableBase<Customer>
    {
        public override string TableName => nameof(Customer);
        public override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(k => k.CustomerId);

            builder.Property(p => p.CustomerId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.CustomerCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.CustomerName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.CustomerGroup).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);
            builder.Property(p => p.ShortName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.Distributor).HasColumnType(SqlColumnFor.Code).HasColumnOrder(6);
            builder.Property(p => p.AccountNo).HasColumnType(SqlColumnFor.CombineCode).HasColumnOrder(7);

            builder.HasMany(m => m.Documents).WithOne(o => o.Customer).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.CustomerProducts).WithOne(o => o.Customer).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.SupplierCustomers).WithOne(o => o.Customer).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.TradeInvesments).WithOne(o => o.Customer).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
