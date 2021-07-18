using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class StateProcessConfiguration : EntityConfigurationBase<StateProcess>
    {
        public override string TableName => nameof(StateProcess);
        public override void ConfigureEntity(EntityTypeBuilder<StateProcess> builder)
        {
            builder.HasKey(k => k.StateProcessId);

            builder.Property(p => p.StateProcessId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.WorkflowStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.ActionId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.ActivityId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(4);

            builder.Property(p => p.ActivityCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(5);
            builder.Property(p => p.ActionCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(6);
            builder.Property(p => p.ActivityName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(7);
            builder.Property(p => p.ActionName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(8);
            builder.Property(p => p.ActivityPiority).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(9);
            builder.Property(p => p.ActionPiority).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(10);

            builder.HasOne(d => d.WorkflowState).WithMany(m => m.StateProcesses).HasForeignKey(f => f.WorkflowStateId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.WorkflowActivity).WithMany(m => m.StateProcesses).HasForeignKey(f => f.ActivityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.WorkflowAction).WithMany(m => m.StateProcesses).HasForeignKey(f => f.ActionId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
