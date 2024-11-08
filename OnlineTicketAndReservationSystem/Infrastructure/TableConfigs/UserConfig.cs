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

            builder.HasOne(x => x.CreateUser).WithMany().HasForeignKey(x => x.CreatedUserId);
            builder.HasOne(x => x.UpdateUser).WithMany().HasForeignKey(x => x.UpdatedUserId);
            builder.HasOne(x => x.Avatar).WithMany().HasForeignKey(x => x.AvatarId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
