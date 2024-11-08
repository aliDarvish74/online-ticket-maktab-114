using DataTransferObject.DTOClasses;
using Model.Entities;

namespace Service.ServiceInterfaces
{
    public interface IBlobService : IServiceBase<Blob, BlobDTO, int>
    {
    }
}
