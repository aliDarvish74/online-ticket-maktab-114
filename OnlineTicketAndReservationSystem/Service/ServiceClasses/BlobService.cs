using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Model.Entities;
using Service.ServiceInterfaces;

namespace Service.ServiceClasses
{
    public class BlobService : IBlobService
    {
        private readonly IBaseRepository<Blob, int> _blobRepository;

        public BlobService(IBaseRepository<Blob, int> blobRepository)
        {
            _blobRepository = blobRepository;
        }

        public BlobDTO TranslateToDTO(Blob entity)
        {
            return entity.Adapt<BlobDTO>();
        }

        public Blob TranslateToEntity(BlobDTO dto)
        {
            return dto.Adapt<Blob>();
        }
    }
}
