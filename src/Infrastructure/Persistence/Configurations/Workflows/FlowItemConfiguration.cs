using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class FlowItemConfiguration : EntityConfigurationBase<FlowItem>
    {
        public override string TableName => nameof(FlowItem);
        public override void ConfigureEntity(EntityTypeBuilder<FlowItem> builder)
        {
            builder.HasKey(k => k.FlowItemId);

            builder.Property(p => p.FlowItemId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.FlowItemCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.FlowItemName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);

            builder.HasMany(m => m.StateFlowItems).WithOne(o => o.FlowItem).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
