using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class DocumentTypeConfiguration : EntityConfigurationAuditableBase<DocumentType>
    {
        public override string TableName => nameof(DocumentType);

        public override void ConfigureEntity(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasKey(k => k.DocumentTypeId);

            builder.Property(p => p.DocumentTypeId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.WorkflowId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2).IsRequired();
            builder.Property(p => p.DocumentTypeCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(3);
            builder.Property(p => p.DocumentTypeName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(4);
            builder.Property(p => p.DocumentTypeDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(5);

            builder.HasOne(o => o.Workflow).WithMany(m => m.DocumentTypes).HasForeignKey(f => f.WorkflowId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(m => m.Documents).WithOne(o => o.DocumentType).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
