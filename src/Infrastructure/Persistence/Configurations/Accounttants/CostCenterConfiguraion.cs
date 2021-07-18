using System;
using GFCA.Domain.Entities.Accountants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Accounttants
{
    public class CostCenterConfiguraion : EntityConfigurationBase<CostCenter>
    {
        public override string TableName => nameof(CostCenter);
        public override void ConfigureEntity(EntityTypeBuilder<CostCenter> builder)
        {
            builder.HasKey(k => k.CostCenterId);

            builder.Property(p => p.CostCenterId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.CompanyId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2).IsRequired(false);
            builder.Property(p => p.SourceFundId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3).IsRequired(false);
            builder.Property(p => p.CenterCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);
            builder.Property(p => p.CenterName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.Site).HasColumnType(SqlColumnFor.Description).HasColumnOrder(6).IsRequired(false);


            builder.HasOne(o => o.Company).WithMany(m => m.CostCenters).HasForeignKey(f => f.CompanyId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.SourceFund).WithMany(m => m.CostCenters).HasForeignKey(f => f.SourceFundId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.FixedContracts).WithOne(o => o.CostCenter).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.Budgets).WithOne(o => o.CostCenter).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
