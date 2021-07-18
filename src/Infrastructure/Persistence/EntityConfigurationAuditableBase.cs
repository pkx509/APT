using System;
using GFCA.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence
{
    public abstract class EntityConfigurationAuditableBase<TEntity>
        : EntityConfigurationBase<TEntity>
        where TEntity : AuditableEntity
    {

        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(TableName, SchemaName);

            ConfigureEntity(builder);

            builder.Property(e => e.CreatedBy).HasColumnType(SqlColumnFor.Name).IsRequired().HasColumnOrder(101);
            builder.Property(e => e.CreatedDate).HasColumnType(SqlColumnFor.DateTime).IsRequired().HasDefaultValueSql("(getdate())").HasColumnOrder(102);
            builder.Property(e => e.UpdatedBy).HasColumnType(SqlColumnFor.Name).IsRequired(false).HasColumnOrder(103);
            builder.Property(e => e.UpdatedDate).HasColumnType(SqlColumnFor.DateTime).IsRequired(false).HasColumnOrder(104);
            /*
            Type t = typeof(TEntity);
            if (t == typeof(AuditableEntity) || t.BaseType == typeof(AuditableEntity))
            {
                builder.Property(e => e.CreatedBy).HasColumnType(SqlColumnFor.Name).IsRequired().HasColumnOrder(101);
                builder.Property(e => e.CreatedDate).HasColumnType(SqlColumnFor.DateTime).IsRequired().HasDefaultValueSql("(getdate())").HasColumnOrder(102);
                builder.Property(e => e.UpdatedBy).HasColumnType(SqlColumnFor.Name).IsRequired(false).HasColumnOrder(103);
                builder.Property(e => e.UpdatedDate).HasColumnType(SqlColumnFor.DateTime).IsRequired(false).HasColumnOrder(104);
            }
            */

        }
    }
}
