using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFile
    {
        IEnumerable<FileModel> GetAll();
        IEnumerable<FileModel> GetByRole(string role);
        FileModel GetById(int id);
        Task DeleteFile(int id);
        Task SetFile(string name, string about, string path, string icon, string role);
    }
}
