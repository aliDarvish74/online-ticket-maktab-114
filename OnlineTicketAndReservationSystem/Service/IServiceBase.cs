using DataTransferObject;
using Infrastructure.RepositoryPattern;
using Model;

namespace Service
{
    public interface IServiceBase<Entity, DTO, KeyTypeId> where Entity : BaseEntity<KeyTypeId> where DTO : BaseDTO<KeyTypeId> where KeyTypeId : struct
    {
        public IBaseRepository<Entity, KeyTypeId> RepositoryOfEntity { get; set; }
        DTO TranslateToDTO(Entity entity);
        Entity TranslateToEntity(DTO model);
    }
}
