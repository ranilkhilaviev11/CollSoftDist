using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class FileService : IFile
    {
        private readonly ApplicationContext _ctx;
        public FileService(ApplicationContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<FileModel> GetAll()
        {
            return _ctx.Files
                .Include(file => file.Roles);
        }

        public FileModel GetById(int id)
        {
            return GetAll().Where(file => file.Id == id)
                .First();
        }

        public IEnumerable<FileModel> GetByPost(string post)
        {
           return GetAll().Where(file 
               => file.Roles
               .Any(p => p.Name == post));
        }

        public async Task DeleteFile(int id)
        {
            var file = _ctx.Files.Where(f => f.Id == id).First();
            if (file != null)
            {
                _ctx.Files.Remove(file);
                await _ctx.SaveChangesAsync();
            }
        }

        public async Task SetFile(string name,  string about, string path, string icon)
        {
            var file = new FileModel
            {
                Name = name,
                About = about,
                Path = path,
                Icon = icon
            };
            _ctx.Files.Add(file);
            await _ctx.SaveChangesAsync();
        }
    }
}
