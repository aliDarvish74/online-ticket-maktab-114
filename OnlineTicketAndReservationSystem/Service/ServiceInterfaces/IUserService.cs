using DataTransferObject.DTOClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Model.Entities;


namespace Service.ServiceInterfaces
{
    public interface IUserService : IServiceBase<User, UserDTO, Guid>
    {
        Task<UserDTO> GetAsync(Guid id);
        Task<IdentityResult> CreateUser(UserDTO user);
        Task<List<UserDTO>> GetAllUsers();
        Task<IList<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync();
        Task<SignInResult> LoginToSystem(string username, string password);
    }
}
