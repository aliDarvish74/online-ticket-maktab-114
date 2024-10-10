using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.Property(x => x.UserName).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.FirstName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);

            var id = Guid.Parse("EFE3A5F8-2198-4E31-899E-A3CD19E96D50");
            builder.HasData(new User { CreatedDateTime = new DateTime(), PasswordHash = "123", FirstName = "kiji", Id = id, CreatedUserId = id, UpdatedUserId = id, UpdatedDataTime = DateTime.Now, UserName = "user1", LastName = "..", Email = "aa@gmail.com" });
        }
    }
}
