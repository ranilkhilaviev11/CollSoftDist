using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public interface IUser
    {
        IEnumerable<User> GetAll();
        User CreateUserWithoutPass(string Email);
        Task CreateUserWithPass(User user, string Password);
        Task GetCookie(User user);
    }
}
