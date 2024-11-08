using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Data;

namespace Infrastructure.TableConfigs
{
    internal class TicketConfig : BaseEntityTypeConfiguration<Ticket, Guid>
    {
        public override void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable(nameof(Ticket));
            RequireTraceable = true;
            UseForTraceable = true;
            GeneratedValueForKey = true;
            base.Configure(builder);

            builder.HasOne(x => x.User).WithMany(x => x.Tickets).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.BuyDate).IsRequired();
            builder.Property(x => x.TicketNumber).HasColumnType(SqlDbType.VarChar.ToString()).IsRequired().HasMaxLength(5);
        }
    }
}
