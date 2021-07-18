using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class WorkflowStateConfiguration : EntityConfigurationBase<WorkflowState>
    {
        public override string TableName => nameof(WorkflowState);
        public override void ConfigureEntity(EntityTypeBuilder<WorkflowState> builder)
        {
            builder.HasKey(k => k.WorkflowStateId);

            builder.Property(p => p.WorkflowStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.PreviousStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2).IsRequired(false);
            builder.Property(p => p.WorkflowId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.StateName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);
            builder.Property(p => p.StateDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(5).IsRequired(false);
            builder.Property(p => p.NotifySubject).HasColumnType(SqlColumnFor.CodeRef).HasColumnOrder(6);
            builder.Property(p => p.NotifyMessage).HasColumnType(SqlColumnFor.Description).HasColumnOrder(7);
            builder.Property(p => p.BeginDate).HasColumnType(SqlColumnFor.DateTime).HasColumnOrder(8).HasDefaultValueSql("getdate()");
            builder.Property(p => p.EndDate).HasColumnType(SqlColumnFor.DateTime).HasColumnOrder(9).HasDefaultValueSql("cast('9999-12-31T11:59:59' as datetime)");

            builder.HasOne(d => d.Workflow).WithMany(m => m.WorkflowStates).HasForeignKey(f => f.WorkflowId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.PreviousState).WithMany(m => m.NextState).HasForeignKey(f => f.PreviousStateId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.StateFlowItems).WithOne(o => o.WorkflowState).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.ActorStates).WithOne(o => o.WorkflowState).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.NextState).WithOne(o => o.PreviousState).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
