using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class WorkflowConfiguration : EntityConfigurationAuditableBase<Workflow>
    {
        public override string TableName => nameof(Workflow);
        public override void ConfigureEntity(EntityTypeBuilder<Workflow> builder)
        {
            builder.HasKey(k => k.WorkflowId);

            builder.Property(p => p.WorkflowId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.WorkflowName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(2);
            builder.Property(p => p.WorkflowDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(3);
            builder.Property(p => p.BeginDate).HasColumnType(SqlColumnFor.DateTime).HasColumnOrder(4);
            builder.Property(p => p.EndDate).HasColumnType(SqlColumnFor.DateTime).HasColumnOrder(5);

            builder.HasMany(m => m.WorkflowStates).WithOne(o => o.Workflow).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.DocumentTypes).WithOne(o => o.Workflow).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
