using System;
using GFCA.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFCA.Infrastructure.Persistence
{
    public abstract class EntityConfigurationBase<TEntity>
        : IEntityTypeConfiguration<TEntity>
        where TEntity : class
    {

        public virtual string SchemaName { get; } = "dbo";
        public abstract string TableName { get; }
        public abstract void ConfigureEntity(EntityTypeBuilder<TEntity> builder);

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(TableName, SchemaName);

            ConfigureEntity(builder);

        }

    }
}
