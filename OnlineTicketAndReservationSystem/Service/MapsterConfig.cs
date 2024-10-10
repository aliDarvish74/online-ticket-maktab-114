using DataTransferObject.DTOClasses;
using Mapster;
using Model.Entities;

namespace Service
{
    public static class MapsterConfig
    {
        public static void RegisterMapping()
        {
            TypeAdapterConfig<Role, RoleDTO>.NewConfig()
                .Map(x => x.Description, y => y.RoleDescription)
                .Map(x => x.StatusOfRole, y => y.RoleStatusId)
                .Map(x => x.PersianName, y => y.RolePersianName)
                .Map(x => x.EnglishName, y => y.RoleName);
        }
    }
}
