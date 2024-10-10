using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(nameof(Role));

            builder.Property(x => x.RoleName).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.RolePersianName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.RoleDescription).IsRequired(false).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(500);
        }
    }
}
