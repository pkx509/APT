using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class DocumentActionConfiguration : EntityConfigurationBase<DocumentAction>
    {
        public override string TableName => nameof(DocumentAction);

        public override void ConfigureEntity(EntityTypeBuilder<DocumentAction> builder)
        {
            builder.HasKey(k => k.DocumentActionId);

            builder.Property(p => p.DocumentActionId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.DocumentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.ActorId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.ActorName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);
            builder.Property(p => p.TimeStamp).HasColumnType(SqlColumnFor.DateTime).HasColumnOrder(5);
            builder.Property(p => p.Comment).HasColumnType(SqlColumnFor.Description).HasColumnOrder(6);

            builder.HasOne(d => d.Document).WithMany(m => m.DocumentActions).HasForeignKey(f => f.DocumentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Actor).WithMany(m => m.DocumentActions).HasForeignKey(f => f.ActorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
