using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace DAL
{
    public interface IUser
    {
        IEnumerable<User> GetAll();
        User CreateUserWithoutPass(string Email);
        Task<IdentityResult> CreateUserWithPass(User user, string Password);
        Task GetCookie(User user);
        Task<SignInResult> PasswordSignInAsync(string Email, string Password, bool RememberMe);
        Task<User> FindUserByIdAsync(string id);
        void EditUser(User user, string Email);
        Task<IdentityResult> UserManagerUpdateAsync(User user);
        Task<IdentityResult> UserManagerDeleteAsync(User user);
    }
}
