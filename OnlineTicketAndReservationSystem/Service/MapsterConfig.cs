﻿using DataTransferObject.DTOClasses;
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
        }
    }
}
