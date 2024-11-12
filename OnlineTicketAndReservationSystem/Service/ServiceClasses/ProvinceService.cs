using DataTransferObject.DTOClasses;
using Infrastructure.Migrations;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.AspNetCore.Http;
using Model.Entities;
using Service.ServiceInterfaces;

namespace Service.ServiceClasses
{
    public class ProvinceService : IProvinceService
    {
        private readonly IUserService _userService;
        private readonly IBaseRepository<Province, Guid> _provinceRepository;
        private IHttpContextAccessor _contextAccessor;
        public ProvinceService(IBaseRepository<Province, Guid> provinceRepository, IUserService userService, IHttpContextAccessor contextAccessor)
        {
            _provinceRepository = provinceRepository;
            _userService = userService;
            _contextAccessor = contextAccessor;
        }

        public async Task<ProvinceDTO> CreateProvince(ProvinceDTO provinceDTO)
        {
            var rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads");
            var address = Path.Combine(rootFolder, $"{provinceDTO.Name}-{provinceDTO.ProvinceFile.FileName}");
            provinceDTO.Picture = new BlobDTO() { FileAddress = address, FileSize = (int)(provinceDTO.ProvinceFile.Length / 1000), MimeType = provinceDTO.ProvinceFile.ContentType };

            var province = TranslateToEntity(provinceDTO);
            province.CreatedDateTime = DateTime.Now;
            province.UpdatedDataTime = DateTime.Now;
            var user = await _userService.GetCurrentUser(_contextAccessor.HttpContext);
            province.CreatedUserId = user.Id;
            province.UpdatedUserId = user.Id;

            var result = await _provinceRepository.CreateDataAsync(province);
            provinceDTO.ProvinceFile.CopyTo(new FileStream(address, FileMode.Create));

            return provinceDTO;
        }

        public async Task<List<ProvinceDTO>> GetAllProvinceList()
        {
            var provinces = await _provinceRepository.GetAllAsync();
            return provinces.ProjectToType<ProvinceDTO>().ToList();
        }

        public async Task<ProvinceDTO> GetProvinceById(Guid id)
        {
            var data = await _provinceRepository.GetByIdAsync(id);
            return TranslateToDTO(data);
        }

        public ProvinceDTO TranslateToDTO(Province entity) => entity.Adapt<ProvinceDTO>();

        public Province TranslateToEntity(ProvinceDTO dto) => dto.Adapt<Province>();
    }
}
