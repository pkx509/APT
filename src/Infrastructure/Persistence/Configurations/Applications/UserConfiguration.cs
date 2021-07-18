using System;
using GFCA.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFCA.Infrastructure.Persistence.Configurations.Applications
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public string TableName => nameof(User);
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(TableName);
        }
    }
}
