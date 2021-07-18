using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class ActorStateConfiguration : EntityConfigurationBase<ActorState>
    {
        public override string TableName => nameof(ActorState);
        public override void ConfigureEntity(EntityTypeBuilder<ActorState> builder)
        {
            builder.HasKey(k => k.ActorStateId);

            builder.Property(p => p.ActorStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.WorkflowStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.ActorId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.ContactType).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);
            builder.Property(p => p.RoleState).HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.User).HasColumnType(SqlColumnFor.Name).HasColumnOrder(6);
            builder.Property(p => p.Position).HasColumnType(SqlColumnFor.Name).HasColumnOrder(7);
            builder.Property(p => p.OperatorConditionId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(8);
            builder.Property(p => p.OperatorCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(9);
            builder.Property(p => p.LimitValue).HasColumnType(SqlColumnFor.Value).HasColumnOrder(10).IsRequired(false);

            builder.HasOne(d => d.Actor).WithMany(m => m.ActorStates).HasForeignKey(f => f.ActorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.WorkflowState).WithMany(m => m.ActorStates).HasForeignKey(f => f.WorkflowStateId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.OperatorCondition).WithMany(m => m.ActorStates).HasForeignKey(f => f.OperatorConditionId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
