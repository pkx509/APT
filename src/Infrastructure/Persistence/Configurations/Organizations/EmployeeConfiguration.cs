using System;
using GFCA.Domain.Entities.Organizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Organizations
{
    public class EmployeeConfiguration : EntityConfigurationAuditableBase<Employee>
    {
        public override string TableName => nameof(Employee);
        public override void ConfigureEntity(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("EmployeeId").HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.DepartmentId).HasColumnName("DepartmentId").HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.Code).HasColumnName("EmployeeCode").HasColumnType(SqlColumnFor.Code).HasColumnOrder(3);
            builder.Property(p => p.Prefix).HasColumnName("Prefix").HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType(SqlColumnFor.Name).HasColumnOrder(5);
            builder.Property(p => p.LastName).HasColumnName("LastName").HasColumnType(SqlColumnFor.Name).HasColumnOrder(6);
            builder.Property(p => p.Position).HasColumnName("Position").HasColumnType(SqlColumnFor.Name).HasColumnOrder(7);
            builder.Property(p => p.Salary).HasColumnName("Salary").HasColumnType(SqlColumnFor.Mesurement).HasColumnOrder(8);
            builder.Property(p => p.Email).HasColumnName("Email").HasColumnType(SqlColumnFor.Name).HasColumnOrder(9);

            builder.HasOne(o => o.Department).WithMany(m => m.Employees).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
