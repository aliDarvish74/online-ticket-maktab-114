using DataTransferObject.DTOClasses;
using Model.Entities;
using Shared;

namespace Service.ServiceInterfaces
{
    public interface IProvinceService : IServiceBase<Province, ProvinceDTO, Guid>
    {
        Task<ProvinceDTO> CreateProvince(ProvinceDTO provinceDTO);
        Task<List<ProvinceDTO>> GetAllProvinceList();
        Task<ProvinceDTO> GetProvinceById(Guid id);
        Task<IQueryable<Province>> GetAllProvinceAsQueryable();
        Task<PaginatedList<ProvinceDTO>> GetProvinceListAsPagination(int pagesize, int pageindex, string searchName);
    }
}
