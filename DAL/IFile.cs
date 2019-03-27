using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public interface IFile
    {
        IEnumerable<FileModel> GetAll();
        IEnumerable<FileModel> GetByPost(string post);
        FileModel GetById(int id);
        Task SetFile(string name, string path, string icon);
    }
}
