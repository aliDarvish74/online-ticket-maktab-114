using DataTransferObject.DTOClasses;
using Model.Entities;

namespace Service.ServiceInterfaces
{
    public interface IRoleService : IServiceBase<Role, RoleDTO, Guid>
    {
    }
}
