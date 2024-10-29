using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Infrastructure.TableConfigs
{
    internal class CityConfig : BaseEntityTypeConfiguration<City, Guid>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            RequireTraceable = true;
            UseForTraceable = true;
            GeneratedValueForKey = true;
            base.Configure(builder);

            builder.HasOne(x => x.Province).WithMany(x => x.Cities).HasForeignKey(x => x.ProvinceId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
