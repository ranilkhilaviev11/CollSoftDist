using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUser
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _sigInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _sigInManager = signInManager;
        }

        public IEnumerable<User> GetAll()
        {
            return _userManager.Users;
        }

        public User CreateUserWithoutPass(string Email)
        {
            return new User
            {
                Email = Email,
                UserName = Email
            };
        }

        public async Task<IdentityResult> CreateUserWithPass(User user, string Password)
        {
            IdentityResult result =  await _userManager.CreateAsync(user, Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(string Email, string Password, bool RememberMe)
        {
            SignInResult result = await _sigInManager.PasswordSignInAsync(Email, Password, RememberMe, false);
            return result;
        }

        public async Task<User> FindUserByIdAsync(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            return user;
        }

        public void EditUser(User user, string Email)
        {
            user.Email = Email;
            user.UserName = Email;
        }

        public async Task<IdentityResult> UserManagerUpdateAsync(User user)
        {
            IdentityResult result = await _userManager.UpdateAsync(user);
            return result;
        }

        public async Task<IdentityResult> UserManagerDeleteAsync(User user)
        {
            IdentityResult result = await _userManager.DeleteAsync(user);
            return result;
        }

        public  Task GetCookie(User user)
        {
            return _sigInManager.SignInAsync(user, false);
        }

    }
}
