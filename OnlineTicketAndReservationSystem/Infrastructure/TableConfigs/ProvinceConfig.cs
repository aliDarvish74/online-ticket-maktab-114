using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Infrastructure.TableConfigs
{
    internal class ProvinceConfig : BaseEntityTypeConfiguration<Province, Guid>
    {
        public override void Configure(EntityTypeBuilder<Province> builder)
        {
            RequireTraceable = true;
            UseForTraceable = true;
            GeneratedValueForKey = true;
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.ProvincePicture).WithMany().HasForeignKey(x => x.ProvincePictureId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
    }
}
