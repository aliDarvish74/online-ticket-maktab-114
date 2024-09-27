using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryPattern.Classes
{
    internal class RoleRepository
    {
        private readonly IBaseRepository<Role, Guid> _roleRepo;

        public RoleRepository(IBaseRepository<Role, Guid> roleRepo)
        {
            _roleRepo = roleRepo;
        }

        public void Test()
        {
            var ttt = _roleRepo.GetAllAsync(x => x, null, x => x.Include(x => x.CreatedUser).ThenInclude(u => u.UpdatedUser));
        }
    }
}
