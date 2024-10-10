using DataTransferObject.DTOClasses;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using Service.ServiceInterfaces;

namespace Service.ServiceClasses
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;
        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<RoleDTO> CreateRole(RoleDTO roleDTO)
        {
            var data = TranslateToEntity(roleDTO);
            await _roleManager.CreateAsync(data);
            return roleDTO;
        }

        public RoleDTO TranslateToDTO(Role entity)
        {
            return entity.Adapt<RoleDTO>();
        }

        public Role TranslateToEntity(RoleDTO dto)
        {
            return dto.Adapt<Role>();
        }
    }
}
