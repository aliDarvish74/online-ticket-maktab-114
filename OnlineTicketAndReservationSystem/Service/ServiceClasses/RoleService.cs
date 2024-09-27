using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Model.Entities;
using Service.ServiceInterfaces;

namespace Service.ServiceClasses
{
    public class RoleService : IRoleService
    {
        public IBaseRepository<Role, Guid> RepositoryOfEntity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RoleDTO TranslateToDTO(Role entity)
        {
            throw new NotImplementedException();
        }

        public Role TranslateToEntity(RoleDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
