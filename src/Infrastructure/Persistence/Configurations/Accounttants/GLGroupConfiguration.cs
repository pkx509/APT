using System;
using GFCA.Domain.Entities.Accountants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Accounttants
{
    public class GLGroupConfiguration : EntityConfigurationBase<GLGroup>
    {
        public override string TableName => nameof(GLGroup);

        public override void ConfigureEntity(EntityTypeBuilder<GLGroup> builder)
        {
            builder.HasKey(k => k.GroupId);

            builder.Property(p => p.GroupId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.GroupPolicy).HasColumnType(SqlColumnFor.Name).HasColumnOrder(2);
            builder.Property(p => p.GroupName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);

            builder.HasMany(m => m.GLAccounts).WithOne(o => o.GLGroup).OnDelete(DeleteBehavior.SetNull);
        }

    }
}
