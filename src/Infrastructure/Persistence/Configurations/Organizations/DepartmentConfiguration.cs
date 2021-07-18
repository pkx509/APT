using System;
using GFCA.Domain.Entities.Organizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Organizations
{
    public class DepartmentConfiguration : EntityConfigurationAuditableBase<Department>
    {
        public override string TableName => nameof(Department);
        public override void ConfigureEntity(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasAlternateKey(k => new { k.CompanyCode, k.BranchCode, k.Code });

            builder.Property(p => p.Id).HasColumnName("DepartmentId").HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.CompanyId).HasColumnName("CompanyId").HasColumnType(SqlColumnFor.Id).HasColumnOrder(2).IsRequired(true);
            builder.Property(p => p.CompanyCode).HasColumnName("CompanyCode").HasColumnType(SqlColumnFor.Code).HasColumnOrder(3);
            builder.Property(p => p.BranchCode).HasColumnName("BranchCode").HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);
            builder.Property(p => p.BranchName).HasColumnName("BranchName").HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.Code).HasColumnName("DepartmentCode").HasColumnType(SqlColumnFor.Code).HasColumnOrder(6);
            builder.Property(p => p.Name).HasColumnName("DepartmentName").HasColumnType(SqlColumnFor.Name).HasColumnOrder(7);

            builder.HasMany(m => m.Employees).WithOne(o => o.Department).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(o => o.Company).WithMany(m => m.Departments).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
