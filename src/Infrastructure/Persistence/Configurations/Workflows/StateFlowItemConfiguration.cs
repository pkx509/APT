using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class StateFlowItemConfiguration : EntityConfigurationBase<StateFlowItem>
    {
        public override string TableName => nameof(StateFlowItem);
        public override void ConfigureEntity(EntityTypeBuilder<StateFlowItem> builder)
        {
            builder.HasKey(k => k.StateFlowItemId);

            builder.Property(p => p.StateFlowItemId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.WorkflowStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.FlowItemId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.FlowItemCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);
            builder.Property(p => p.FlowItemName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.Sort).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(6);

            builder.HasOne(d => d.FlowItem).WithMany(m => m.StateFlowItems).HasForeignKey(f => f.FlowItemId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.WorkflowState).WithMany(m => m.StateFlowItems).HasForeignKey(f => f.WorkflowStateId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
