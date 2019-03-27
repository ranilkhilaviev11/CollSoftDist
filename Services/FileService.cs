using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

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
                .Include(file => file.Posts);
        }

        public FileModel GetById(int id)
        {
            return GetAll().Where(file => file.Id == id)
                .First();
        }

        public IEnumerable<FileModel> GetByPost(string post)
        {
           return GetAll().Where(file 
               => file.Posts
               .Any(p => p.Name == post));
        }
        public async Task SetFile(string name, string path, string icon)
        {
            var file = new FileModel
            {
                Name = name,
                
                Path = path,
                Icon = icon
            };
            _ctx.Files.Add(file);
            await _ctx.SaveChangesAsync();
        }
    }
}
