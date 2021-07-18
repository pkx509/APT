using System;
using GFCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFCA.Infrastructure.Persistence.Configurations
{
    public class EmailInboundConfiguration : EntityConfigurationAuditableBase<EmailInbound>
    {
        public override string TableName => "tb_email_inbound";
        public override void ConfigureEntity(EntityTypeBuilder<EmailInbound> builder)
        {

            builder.HasKey(o => o.EmailID);

            builder.Property(t => t.EmailID).HasColumnName("email_id").HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(t => t.FromEmail).HasColumnName("from_email").HasColumnOrder(2).HasColumnType("varchar(200)");
            builder.Property(t => t.DataPath).HasColumnName("data_path").HasColumnOrder(3).HasColumnType("varchar(4000)");
            builder.Property(t => t.IsActive).HasColumnName("is_active").HasColumnOrder(4).IsRequired().HasColumnType("int").HasDefaultValueSql("0");
            builder.Property(t => t.Remark).HasColumnName("remark").HasColumnOrder(5).HasColumnType("varchar(4000)");
            
        }
    }

}
