using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class OperatorConditionConfiguration : EntityConfigurationBase<OperatorCondition>
    {
        public override string TableName => nameof(OperatorCondition);
        public override void ConfigureEntity(EntityTypeBuilder<OperatorCondition> builder)
        {
            builder.HasKey(k => k.OperatorConditionId);

            builder.Property(p => p.OperatorConditionId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.OperatorCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.OperatoDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(3);

        }
    }
}
