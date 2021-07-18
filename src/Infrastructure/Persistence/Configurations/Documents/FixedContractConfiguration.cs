using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class FixedContractConfiguration : EntityConfigurationAuditableBase<FixedContract>
    {
        public override string TableName => nameof(FixedContract);
        public override void ConfigureEntity(EntityTypeBuilder<FixedContract> builder)
        {
            builder.HasKey(k => k.FixedContractId);

            builder.Property(p => p.FixedContractId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.DocumentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.AccountId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.CostCenterId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(4);
            builder.Property(p => p.TradeInvesmentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(5);
            builder.Property(p => p.ConditionType).HasColumnType(SqlColumnFor.Name).HasColumnOrder(6);
            builder.Property(p => p.ContractCategory).HasColumnType(SqlColumnFor.Code).HasColumnOrder(7);
            builder.Property(p => p.ContractDesc).HasColumnType(SqlColumnFor.Description).HasColumnOrder(8);
            builder.Property(p => p.UOM).HasColumnType(SqlColumnFor.Code).HasColumnOrder(9);
            builder.Property(p => p.DateRefForm).HasColumnType(SqlColumnFor.Name).HasColumnOrder(10);

            builder.Property(p => p.M01JAN).HasColumnType(SqlColumnFor.Value).HasColumnOrder(51).IsRequired(false);
            builder.Property(p => p.M02FEB).HasColumnType(SqlColumnFor.Value).HasColumnOrder(52).IsRequired(false);
            builder.Property(p => p.M03MAR).HasColumnType(SqlColumnFor.Value).HasColumnOrder(53).IsRequired(false);
            builder.Property(p => p.M04APR).HasColumnType(SqlColumnFor.Value).HasColumnOrder(54).IsRequired(false);
            builder.Property(p => p.M05MAY).HasColumnType(SqlColumnFor.Value).HasColumnOrder(55).IsRequired(false);
            builder.Property(p => p.M06JUN).HasColumnType(SqlColumnFor.Value).HasColumnOrder(56).IsRequired(false);
            builder.Property(p => p.M07JUL).HasColumnType(SqlColumnFor.Value).HasColumnOrder(57).IsRequired(false);
            builder.Property(p => p.M08AUG).HasColumnType(SqlColumnFor.Value).HasColumnOrder(58).IsRequired(false);
            builder.Property(p => p.M09SEP).HasColumnType(SqlColumnFor.Value).HasColumnOrder(59).IsRequired(false);
            builder.Property(p => p.M10OCT).HasColumnType(SqlColumnFor.Value).HasColumnOrder(60).IsRequired(false);
            builder.Property(p => p.M11NOV).HasColumnType(SqlColumnFor.Value).HasColumnOrder(61).IsRequired(false);
            builder.Property(p => p.M12DEC).HasColumnType(SqlColumnFor.Value).HasColumnOrder(62).IsRequired(false);

            builder.HasOne(d => d.GLAccount).WithMany(m => m.FixedContracts).HasForeignKey(f => f.AccountId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.TradeInvesment).WithMany(m => m.FixedContracts).HasForeignKey(f => f.TradeInvesmentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.CostCenter).WithMany(m => m.FixedContracts).HasForeignKey(f => f.CostCenterId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Brand).WithMany(m => m.FixedContracts).HasForeignKey(f => f.BrandId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Document).WithMany(m => m.FixedContracts).HasForeignKey(f => f.DocumentId).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
