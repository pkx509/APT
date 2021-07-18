using System;
using GFCA.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Sales
{
    public class TradeInvesmentConfiguration : EntityConfigurationAuditableBase<TradeInvesment>
    {
        public override string TableName => nameof(TradeInvesment);

        public override void ConfigureEntity(EntityTypeBuilder<TradeInvesment> builder)
        {
            builder.HasKey(k => k.TradeInvesmentId);

            builder.Property(p => p.TradeInvesmentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.TradeCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.TradeName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.SubGroup).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);
            builder.Property(p => p.DataSource).HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.IsFixedContract).HasColumnType(SqlColumnFor.Checker).HasColumnOrder(6);
            builder.Property(p => p.Deductable).HasColumnType(SqlColumnFor.Checker).HasColumnOrder(7);
            builder.Property(p => p.ToleranceLevel).HasColumnType(SqlColumnFor.Name).HasColumnOrder(8);
            builder.Property(p => p.ToleranceLower).HasColumnType(SqlColumnFor.Value).HasColumnOrder(9);
            builder.Property(p => p.ToleranceUpper).HasColumnType(SqlColumnFor.Value).HasColumnOrder(10);
            builder.Property(p => p.CostElement).HasColumnType(SqlColumnFor.Name).HasColumnOrder(11);

            builder.HasOne(o => o.Channel).WithMany(m => m.TradeInvesments).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.GLAccount).WithMany(m => m.TradeInvesments).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Customer).WithMany(m => m.TradeInvesments).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.FixedContracts).WithOne(o => o.TradeInvesment).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
