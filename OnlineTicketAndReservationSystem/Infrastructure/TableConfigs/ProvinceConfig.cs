using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    internal class ProvinceConfig : BaseEntityTypeConfiguration<Province, Guid>
    {
        public override void Configure(EntityTypeBuilder<Province> builder)
        {

            base.RequireTraceable = true;
            base.UseForTraceable = true;
            base.GeneratedValueForKey = true;
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            var userid = Guid.Parse("EFE3A5F8-2198-4E31-899E-A3CD19E96D50");
            var id = Guid.Parse("84C3D84B-B54F-4E03-8FC6-5130CD643C47");
            builder.HasData(new Province { Id = id, CreatedUserId = userid, UpdatedUserId = userid, CreatedDateTime = DateTime.Now, UpdatedDataTime = DateTime.Now, Name = "تهران" });
        }


    }
}
