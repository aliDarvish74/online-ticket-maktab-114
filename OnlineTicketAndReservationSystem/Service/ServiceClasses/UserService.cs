using DataTransferObject.DTOClasses;
using Mapster;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service.ServiceInterfaces;

namespace Service.ServiceClasses
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUser(UserDTO user)
        {
            User data = TranslateToEntity(user);
            return await _userManager.CreateAsync(data, user.Password);
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            List<User> datas = await _userManager.Users.ToListAsync();
            List<UserDTO> users = datas.Any() ? datas.Select(TranslateToDTO).ToList() : new List<UserDTO>();
            return users;
        }

        public async Task<UserDTO> GetAsync(Guid id)
        {
            User? data = await _userManager.FindByIdAsync(id.ToString());
            return TranslateToDTO(data);
        }

        public async Task<UserDTO> GetCurrentUser(HttpContext context)
        {
            var user = await _userManager.GetUserAsync(context.User);
            return TranslateToDTO(user);
        }

        public async Task<IList<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync()
        {
            return (IList<AuthenticationScheme>)(await _signInManager.GetExternalAuthenticationSchemesAsync());
        }

        public async Task<SignInResult> LoginToSystem(string username, string password)
        {
            SignInResult data = await _signInManager.PasswordSignInAsync(username, password, true, lockoutOnFailure: false);
            return data;
        }
        public UserDTO TranslateToDTO(User entity) => entity.Adapt<UserDTO>();

        public User TranslateToEntity(UserDTO dto) => dto.Adapt<User>();
    }
}
