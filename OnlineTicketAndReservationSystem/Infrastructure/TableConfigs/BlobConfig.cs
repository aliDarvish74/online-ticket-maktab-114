using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class BlobConfig : BaseEntityTypeConfiguration<Blob, int>
    {
        public override void Configure(EntityTypeBuilder<Blob> builder)
        {
            builder.ToTable(nameof(Blob));
            GeneratedValueForKey = false;
            base.Configure(builder);

            builder.Property(x => x.MimeType).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(300);
            builder.Property(x => x.FileAddress).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(1000);
        }
    }
}
