using System;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Workflows
{
    public class ActorConfiguration : EntityConfigurationBase<Actor>
    {
        public override string TableName => nameof(Actor);
        public override void ConfigureEntity(EntityTypeBuilder<Actor> builder)
        {
            builder.HasKey(k => k.ActorId);

            builder.Property(p => p.ActorId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.ActorCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.ActorName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.ActorEmail).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);

            builder.HasMany(m => m.ActorStates).WithOne(o => o.Actor).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.DocumentActions).WithOne(o => o.Actor).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
