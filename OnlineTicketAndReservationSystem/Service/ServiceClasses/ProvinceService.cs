﻿using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service.ServiceInterfaces;
using Shared;

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

        public async Task<IQueryable<Province>> GetAllProvinceAsQueryable()
        {
            return await _provinceRepository.GetAllAsync();
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

        public async Task<PaginatedList<ProvinceDTO>> GetProvinceListAsPagination(int pagesize, int pageindex, string searchName, int? searchCityCount)
        {
            IQueryable<Province> provinces = await _provinceRepository.GetAllAsync(x => x, include: x => x.Include(x => x.Cities));

            if (!string.IsNullOrEmpty(searchName))
                provinces = provinces.Where(x => x.Name.Contains(searchName));
            if (searchCityCount.HasValue)
                provinces = provinces.Where(x => x.Cities.Count == searchCityCount.Value);

            PaginatedList<Province> data = PaginatedList<Province>.Create(provinces, pageindex, pagesize);
            return new PaginatedList<ProvinceDTO>(data.Select(TranslateToDTO).ToList(), provinces.Count(), pageindex, pagesize);
        }

        public ProvinceDTO TranslateToDTO(Province entity) => entity.Adapt<ProvinceDTO>();

        public Province TranslateToEntity(ProvinceDTO dto) => dto.Adapt<Province>();
    }
}
