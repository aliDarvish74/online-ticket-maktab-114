using DataTransferObject.DTOClasses;
using Model.Entities;

namespace Service.ServiceInterfaces
{
    public interface IProvinceService : IServiceBase<Province, ProvinceDTO, Guid>
    {
        Task<ProvinceDTO> CreateProvince(ProvinceDTO provinceDTO);
        Task<List<ProvinceDTO>> GetAllProvinceList();
        Task<ProvinceDTO> GetProvinceById(Guid id);
    }
}
