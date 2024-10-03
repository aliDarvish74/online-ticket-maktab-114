using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Ticket : BaseEntity<Guid>
    {
        public string TicketNumber { get; set; } = NewTicketNumber();
        public DateTime BuyDate { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public int SeatNumber { get; set; }

        public static string NewTicketNumber()
        {
            var random = new Random();
            var res = random.Next(10000,99999).ToString();
            return res;
        }
    }
}
