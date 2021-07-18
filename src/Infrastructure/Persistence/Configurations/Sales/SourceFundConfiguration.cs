using System;
using GFCA.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Sales
{
    public class SourceFundConfiguration : EntityConfigurationBase<SourceFund>
    {
        public override string TableName => nameof(SourceFund);

        public override void ConfigureEntity(EntityTypeBuilder<SourceFund> builder)
        {
            builder.HasKey(k => k.SourceFundId);

            builder.Property(p => p.SourceFundId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.FundCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.FundName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.FundDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(4).IsRequired(false);

            builder.HasMany(m => m.CostCenters).WithOne(o => o.SourceFund).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.Budgets).WithOne(o => o.SourceFund).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
