using System;
using GFCA.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFCA.Infrastructure.Persistence.Configurations.Applications
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public string TableName => nameof(Role);
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(TableName);
            //builder.HasKey(k => k.Id);
        }
    }
}
