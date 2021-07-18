using System;
using GFCA.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFCA.Infrastructure.Persistence.Configurations.Applications
{
    /*
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public string TableName => nameof(UserRole);
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(TableName);
            //builder.HasKey(k => new { k.RoleId, k.UserId });
        }
    }
    */
}
