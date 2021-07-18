using System;
using GFCA.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.BusinessParties
{
    public class ChannelConfiguration : EntityConfigurationAuditableBase<Channel>
    {
        public override string TableName => nameof(Channel);

        public override void ConfigureEntity(EntityTypeBuilder<Channel> builder)
        {
            builder.HasKey(k => k.ChannelId);

            builder.Property(p => p.ChannelId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ChannelCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.ChannelName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.ChannelDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(4);

            builder.HasMany(m => m.Documents).WithOne(o => o.Channel).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.TradeInvesments).WithOne(o => o.Channel).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.SupplierCustomers).WithOne(o => o.Channel).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
