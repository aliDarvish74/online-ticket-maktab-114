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
                .Map(x => x.EnglishName, y => y.RoleName).TwoWays();

            TypeAdapterConfig<User, UserDTO>.NewConfig()
                .Map(x => x.EmailAddress, y => y.Email)
                .Map(x => x.MobileNumber, y => y.PhoneNumber)
                .Map(x => x.EmailAddress, y => y.UserName);

            TypeAdapterConfig<UserDTO, User>.NewConfig()
                .Map(x => x.Email, y => y.EmailAddress)
                .Map(x => x.PhoneNumber, y => y.MobileNumber)
                .Map(x => x.UserName, y => y.EmailAddress)
                .Map(x => x.PasswordHash, y => y.Password);

            TypeAdapterConfig<Blob, BlobDTO>.NewConfig()
                .Map(x => x.FileAddress, y => y.FileAddress)
                .Map(x => x.FileSize, y => y.FileSize)
                .Map(x => x.MimeType, y => y.MimeType);

            TypeAdapterConfig<BlobDTO, Blob>.NewConfig()
                .Map(x => x.FileAddress, y => y.FileAddress)
                .Map(x => x.FileSize, y => y.FileSize)
                .Map(x => x.MimeType, y => y.MimeType);

            TypeAdapterConfig<Province, ProvinceDTO>.NewConfig()
                .Map(x => x.Name, y => y.Name)
                .Map(x => x.Picture, y => y.ProvincePicture);

            TypeAdapterConfig<ProvinceDTO, Province>.NewConfig()
                .Map(x => x.Name, y => y.Name)
                .Map(x => x.ProvincePicture, y => y.Picture);
        }
    }
}
