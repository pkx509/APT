using System;
using GFCA.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Sales
{
    public class TradeActivityConfiguration : EntityConfigurationAuditableBase<TradeActivity>
    {
        public override string TableName => nameof(TradeActivity);

        public override void ConfigureEntity(EntityTypeBuilder<TradeActivity> builder)
        {
            builder.HasKey(k => k.TradeActivityId);

            builder.Property(p => p.TradeActivityId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ActivityType).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.ActivityCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(3);
            builder.Property(p => p.ActivityName).HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);

            builder.Property(p => p.FixedContract).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(5);
            builder.Property(p => p.Deductable).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(6);

            builder.Property(p => p.SaleInTHBCS).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(7);
            builder.Property(p => p.SaleInGrossSale).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(8);
            builder.Property(p => p.SaleInNotSale).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(9);

            builder.Property(p => p.SaleOutTHBCS).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(10);
            builder.Property(p => p.SaleOutGrossSale).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(11);
            builder.Property(p => p.SaleOutNotSale).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(12);

            builder.Property(p => p.NotRelateSaleAbsAmt).HasColumnType(SqlColumnFor.Marker).HasColumnOrder(13);
            builder.Property(p => p.Valuable).HasColumnType(SqlColumnFor.Code).HasColumnOrder(14);
            builder.Property(p => p.Remark).HasColumnType(SqlColumnFor.Description).HasColumnOrder(15);

            builder.HasOne(m => m.GLAccount).WithMany(m => m.TradeActivities).HasForeignKey(f => f.AccountId).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
