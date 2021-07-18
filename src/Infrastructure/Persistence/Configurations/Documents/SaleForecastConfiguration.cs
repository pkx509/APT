using System;
using GFCA.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GFCA.Infrastructure.Persistence.Configurations.Documents
{
    public class SaleForecastConfiguration : EntityConfigurationAuditableBase<SaleForecast>
    {
        public override string TableName => nameof(SaleForecast);
        public override void ConfigureEntity(EntityTypeBuilder<SaleForecast> builder)
        {
            builder.HasKey(k => k.SaleForecastId);

            builder.Property(p => p.SaleForecastId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(1).HasAnnotation("SqlServer:Identity", "1, 1").ValueGeneratedOnAdd();
            builder.Property(p => p.DocumentId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(2);
            builder.Property(p => p.ProductId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(3);
            builder.Property(p => p.ProductCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(4);
            builder.Property(p => p.ForecastType).HasColumnType(SqlColumnFor.Code).HasColumnOrder(5);
            builder.Property(p => p.BrandId).HasColumnType(SqlColumnFor.Id).HasColumnOrder(6);
            builder.Property(p => p.BrandCode).HasColumnType(SqlColumnFor.Code).HasColumnOrder(7);
            builder.Property(p => p.BrandName).HasColumnType(SqlColumnFor.Name).HasColumnOrder(8);

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

            builder.HasOne(d => d.Product).WithMany(m => m.SaleForecasts).HasForeignKey(f => f.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Document).WithMany(m => m.SaleForecasts).HasForeignKey(f => f.DocumentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Brand).WithMany(m => m.SaleForecasts).HasForeignKey(f => f.BrandId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
