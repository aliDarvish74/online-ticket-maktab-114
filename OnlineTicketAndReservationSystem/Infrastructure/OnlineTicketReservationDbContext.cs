using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Reflection;

namespace Infrastructure
{
    public class OnlineTicketReservationDbContext : DbContext
    {
        public OnlineTicketReservationDbContext() { }
        public OnlineTicketReservationDbContext(DbContextOptions<OnlineTicketReservationDbContext> dbContext) : base(dbContext) { }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=OnlineTicket2;TrustServerCertificate=True;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
