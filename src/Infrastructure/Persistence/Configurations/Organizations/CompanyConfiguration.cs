using GFCA.Domain.Entities.Organizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Organizations
{
    public class CompanyConfiguration : EntityConfigurationAuditableBase<Company>
    {
        public override string TableName => nameof(Company);
        public override void ConfigureEntity(EntityTypeBuilder<Company> builder)
        {

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("CompanyId").HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.Code).HasColumnName("CompanyCode").HasColumnType(SqlColumnFor.Code).HasColumnOrder(2);
            builder.Property(p => p.Name).HasColumnName("CompanyName").HasColumnType(SqlColumnFor.Name).HasColumnOrder(3);
            builder.Property(p => p.Address).HasColumnName("Address").HasColumnType(SqlColumnFor.Description).HasColumnOrder(4);

            builder.HasMany(m => m.Departments).WithOne(o => o.Company).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(m => m.CostCenters).WithOne(o => o.Company).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
