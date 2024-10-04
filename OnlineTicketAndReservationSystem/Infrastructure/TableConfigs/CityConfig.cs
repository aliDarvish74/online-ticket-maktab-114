using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    internal class CityConfig : BaseEntityTypeConfiguration<City, Guid>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {

            base.RequireTraceable = true;
            base.UseForTraceable = true;
            base.GeneratedValueForKey = true;

            builder.HasOne(x => x.Province).WithMany(x =>x.Cities).HasForeignKey(x => x.ProvinceId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            var provinceid = Guid.Parse("84C3D84B-B54F-4E03-8FC6-5130CD643C47");
            var userid = Guid.Parse("EFE3A5F8-2198-4E31-899E-A3CD19E96D50");
            builder.HasData(new City { Id = Guid.NewGuid(),ProvinceId =  provinceid ,CreatedDateTime = DateTime.Now,CreatedUserId = userid,UpdatedDataTime = DateTime.Now,UpdatedUserId = userid,Name ="تهران"});
            builder.HasData(new City { Id = Guid.NewGuid(),ProvinceId =  provinceid ,CreatedDateTime = DateTime.Now,CreatedUserId = userid,UpdatedDataTime = DateTime.Now,UpdatedUserId = userid,Name ="کرج"});
            builder.HasData(new City { Id = Guid.NewGuid(),ProvinceId =  provinceid ,CreatedDateTime = DateTime.Now,CreatedUserId = userid,UpdatedDataTime = DateTime.Now,UpdatedUserId = userid,Name ="دماوند"});
            builder.HasData(new City { Id = Guid.NewGuid(),ProvinceId =  provinceid ,CreatedDateTime = DateTime.Now,CreatedUserId = userid,UpdatedDataTime = DateTime.Now,UpdatedUserId = userid,Name ="سعادتشهر"});
            builder.HasData(new City { Id = Guid.NewGuid(),ProvinceId =  provinceid ,CreatedDateTime = DateTime.Now,CreatedUserId = userid,UpdatedDataTime = DateTime.Now,UpdatedUserId = userid,Name ="پرند"});

        }
    }
}
