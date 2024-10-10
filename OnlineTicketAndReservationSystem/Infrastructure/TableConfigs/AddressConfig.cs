using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class AddressConfig : BaseEntityTypeConfiguration<Address, Guid>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.RequireTraceable = true;
            base.UseForTraceable = true;
            base.GeneratedValueForKey = true;

            builder.HasOne(x => x.City).WithMany(x => x.Addresses).HasForeignKey(x => x.CityId).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);
            builder.Property(x => x.PostalCode).HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(10);
        }
    }
}
