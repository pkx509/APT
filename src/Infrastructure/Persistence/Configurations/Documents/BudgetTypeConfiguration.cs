using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class BudgetTypeConfiguration : EntityConfigurationBase<BudgetType>
    {
        public override string TableName => nameof(BudgetType);

        public override void ConfigureEntity(EntityTypeBuilder<BudgetType> builder)
        {
            builder.HasKey(k => k.BudgetTypeId);

            builder.Property(p => p.BudgetTypeId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.BudgetTypeCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.BudgetTypeName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.BudgetTypeDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(4).IsRequired(false);

            builder.HasMany(m => m.Budgets).WithOne(o => o.BudgetType).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
