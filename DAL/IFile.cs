using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFile
    {
        IEnumerable<FileModel> GetAll();
        IEnumerable<FileModel> GetByPost(string post);
        FileModel GetById(int id);
        Task DeleteFile(int id);
        Task SetFile(string name, string about, string path, string icon);
    }
}
