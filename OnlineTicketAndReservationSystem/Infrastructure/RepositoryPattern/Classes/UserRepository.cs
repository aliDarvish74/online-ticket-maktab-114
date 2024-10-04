using Infrastructure.RepositoryPattern.Interfaces;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryPattern.Classes
{
    internal class UserRepository : BaseRepository<User, Guid> , IUserRepository
    {
        public UserRepository(OnlineTicketReservationDbContext dbContext) : base(dbContext) 
        {
        }
    }
}
