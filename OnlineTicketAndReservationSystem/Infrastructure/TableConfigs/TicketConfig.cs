using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    internal class TicketConfig : BaseEntityTypeConfiguration<Ticket,Guid>
    {
        public override void Configure(EntityTypeBuilder<Ticket> builder)
        {
           
            base.RequireTraceable = true;
            base.UseForTraceable = true;
            base.GeneratedValueForKey = true;

            
            builder.HasOne(x => x.User).WithMany(x => x.Tickets).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.BuyDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.TicketNumber).HasColumnType(SqlDbType.VarChar.ToString()).IsRequired().HasMaxLength(5);

            var id = Guid.Parse("EFE3A5F8-2198-4E31-899E-A3CD19E96D50");

            builder.HasData(new Ticket {Id = Guid.NewGuid(), BuyDate = DateTime.Now, UserId = id,CreatedDateTime = DateTime.Now ,UpdatedDataTime = DateTime.Now,CreatedUserId = id,UpdatedUserId = id});
            builder.HasData(new Ticket {Id = Guid.NewGuid(), BuyDate = DateTime.Now, UserId = id,CreatedDateTime = DateTime.Now ,UpdatedDataTime = DateTime.Now,CreatedUserId = id,UpdatedUserId = id});
            builder.HasData(new Ticket {Id = Guid.NewGuid(), BuyDate = DateTime.Now, UserId = id,CreatedDateTime = DateTime.Now ,UpdatedDataTime = DateTime.Now,CreatedUserId = id,UpdatedUserId = id});
            builder.HasData(new Ticket {Id = Guid.NewGuid(), BuyDate = DateTime.Now, UserId = id,CreatedDateTime = DateTime.Now ,UpdatedDataTime = DateTime.Now,CreatedUserId = id,UpdatedUserId = id});
            base.Configure(builder);
        }
        
    }
}
