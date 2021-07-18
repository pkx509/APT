using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class WorkflowActivityConfiguration : EntityConfigurationBase<WorkflowActivity>
    {
        public override string TableName => nameof(WorkflowActivity);
        public override void ConfigureEntity(EntityTypeBuilder<WorkflowActivity> builder)
        {
            builder.HasKey(k => k.ActivityId);

            builder.Property(p => p.ActivityId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ActivityCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.ActivityName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.ActivityPiority).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(4);

            builder.HasMany(m => m.StateProcesses).WithOne(o => o.WorkflowActivity).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
