using System;
using GFCA.Domain.Entities.Accountants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Accounttants
{
    public class GLAccountConfiguration : EntityConfigurationAuditableBase<GLAccount>
    {
        public override string TableName => nameof(GLAccount);

        public override void ConfigureEntity(EntityTypeBuilder<GLAccount> builder)
        {
            builder.HasKey(k => k.AccountId);

            builder.Property(p => p.AccountId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.GLGroupId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.GLCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(3);
            builder.Property(p => p.GLName).HasColumnType(SqlColumnFor.CodeRef).HasColumnOrder(4);
            builder.Property(p => p.Purpose).HasColumnType(SqlColumnFor.Code).HasColumnOrder(5);
            builder.Property(p => p.Remark).HasColumnType(SqlColumnFor.Name).HasColumnOrder(6);

            builder.HasOne(o => o.GLGroup).WithMany(m => m.GLAccounts).HasForeignKey(f => f.GLGroupId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
