using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class UserConfig : BaseEntityTypeConfiguration<User, Guid>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            base.RequireTraceable = true;
            base.UseForTraceable = true;
            base.GeneratedValueForKey = false;

            base.Configure(builder);

            builder.Property(x => x.Username).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.FirstName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);

            var id = Guid.Parse("EFE3A5F8-2198-4E31-899E-A3CD19E96D50");
            builder.HasData(new User { CreatedDateTime = new DateTime(), Password = "123", FirstName = "kiji", Id = id, CreatedUserId = id, UpdatedUserId = id, UpdatedDataTime = DateTime.Now, Username = "user1", LastName = "..", Email = "aa@gmail.com" });
        }
    }
}
