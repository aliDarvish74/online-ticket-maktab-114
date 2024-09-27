using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class RoleConfig : BaseEntityTypeConfiguration<Role, Guid>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(nameof(Role));
            base.RequireTraceable = true;
            base.GeneratedValueForKey = false;
            base.UseForTraceable = true;
            base.Configure(builder);

            builder.Property(x => x.RoleName).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.RolePersianName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.RoleDescription).IsRequired(false).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(500);
        }
    }
}
