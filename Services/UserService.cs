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
                Email = Email
            };
        }

        public Task CreateUserWithPass(User user, string Password)
        {
             return _userManager.CreateAsync(user, Password);
        }

        public  Task GetCookie(User user)
        {
            return _sigInManager.SignInAsync(user, false);
        }

    }
}
