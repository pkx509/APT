using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class WorkflowActionConfiguration : EntityConfigurationBase<WorkflowAction>
    {
        public override string TableName => nameof(WorkflowAction);
        public override void ConfigureEntity(EntityTypeBuilder<WorkflowAction> builder)
        {
            builder.HasKey(k => k.ActionId);

            builder.Property(p => p.ActionId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ActionCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.ActionName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.ActionPiority).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(4);

            builder.HasMany(m => m.StateProcesses).WithOne(o => o.WorkflowAction).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
