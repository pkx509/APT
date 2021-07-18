using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class BudgetConfiguration : EntityConfigurationAuditableBase<Budget>
    {

        public override string TableName => nameof(Budget);
        public override void ConfigureEntity(EntityTypeBuilder<Budget> builder)
        {
            builder.HasKey(k => k.BudgetId);

            builder.Property(p => p.BudgetId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.DocumentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.BudgetTypeId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.BrandId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(4);

            builder.Property(p => p.ActualLastYear).HasColumnType(SqlColumnFor.Value).HasColumnOrder(5).IsRequired(false);
            builder.Property(p => p.BudgetValue).HasColumnType(SqlColumnFor.Value).HasColumnOrder(6);
            builder.Property(p => p.BudgetTargetInYear).HasColumnType(SqlColumnFor.Value).HasColumnOrder(7).IsRequired(false);
            builder.Property(p => p.PercentContribution).HasColumnType(SqlColumnFor.Value).HasColumnOrder(8).IsRequired(false);
            builder.Property(p => p.SaleInvesment).HasColumnType(SqlColumnFor.Value).HasColumnOrder(9).IsRequired(false);

            builder.Property(p => p.CostCenterId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(10).IsRequired(false);
            builder.Property(p => p.CenterName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(11);
            builder.Property(p => p.SourceFundId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(12).IsRequired(false);
            builder.Property(p => p.FundName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(13);

            builder.HasOne(d => d.CostCenter).WithMany(m => m.Budgets).HasForeignKey(f => f.CostCenterId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.BudgetType).WithMany(m => m.Budgets).HasForeignKey(f => f.BudgetTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.SourceFund).WithMany(m => m.Budgets).HasForeignKey(f => f.SourceFundId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Brand).WithMany(m => m.Budgets).HasForeignKey(f => f.BrandId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Document).WithMany(m => m.Budgets).HasForeignKey(f => f.DocumentId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
