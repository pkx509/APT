using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class DocumentConfiguration : EntityConfigurationAuditableBase<Document>
    {

        public override string TableName => nameof(Document);
        public override void ConfigureEntity(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(k => k.DocumentId);

            builder.Property(p => p.DocumentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.DocumentTypeId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.SupplierId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3).IsRequired(false);
            builder.Property(p => p.ChannelId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(4).IsRequired(false);
            builder.Property(p => p.CustomerId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(5).IsRequired(false);

            builder.Property(p => p.DocumentTypeCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(6);
            builder.Property(p => p.DocumentYear).HasColumnType(SqlColumnFor.Year).HasColumnOrder(7);
            builder.Property(p => p.DocumentMonth).HasColumnType(SqlColumnFor.Month).HasColumnOrder(8);
            builder.Property(p => p.ReferenceNo).HasColumnType(SqlColumnFor.Name).HasColumnOrder(9);
            builder.Property(p => p.ClientCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(10);
            builder.Property(p => p.ClientName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(11);
            builder.Property(p => p.ChannelCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(12);
            builder.Property(p => p.ChannelName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(13);
            builder.Property(p => p.CustomerCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(14);
            builder.Property(p => p.CustomerName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(15);
            builder.Property(p => p.TotalSale).HasColumnType(SqlColumnFor.Value).HasColumnOrder(16);
            builder.Property(p => p.TotalInvestment).HasColumnType(SqlColumnFor.Value).HasColumnOrder(17);

            builder.Property(p => p.Version).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(18);
            builder.Property(p => p.Revision).HasColumnType(SqlColumnFor.Sort).HasColumnOrder(19);
            builder.Property(p => p.CurrentStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(20);
            builder.Property(p => p.CurrentState).HasColumnType(SqlColumnFor.Name).HasColumnOrder(21);
            builder.Property(p => p.NextStateId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(22);
            builder.Property(p => p.NextState).HasColumnType(SqlColumnFor.Name).HasColumnOrder(23);

            builder.HasOne(d => d.Supplier).WithMany(m => m.Documents).HasForeignKey(f => f.SupplierId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.DocumentType).WithMany(m => m.Documents).HasForeignKey(f => f.DocumentTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Customer).WithMany(m => m.Documents).HasForeignKey(f => f.CustomerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Channel).WithMany(m => m.Documents).HasForeignKey(f => f.ChannelId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.DocumentActions).WithOne(o => o.Document).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.FixedContracts).WithOne(o => o.Document).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.SaleForecasts).WithOne(o => o.Document).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.Budgets).WithOne(o => o.Document).OnDelete(DeleteBehavior.SetNull);
        }

    }
}
