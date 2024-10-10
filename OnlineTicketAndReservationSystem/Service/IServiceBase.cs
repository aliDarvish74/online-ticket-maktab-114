using DataTransferObject;
using Model;

namespace Service
{
    public interface IServiceBase<Entity, DTO, KeyTypeId> where Entity : class where DTO : BaseDTO<KeyTypeId> where KeyTypeId : struct
    {
        DTO TranslateToDTO(Entity entity);
        Entity TranslateToEntity(DTO dto);
    }
}
