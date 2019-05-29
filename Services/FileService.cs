using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
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
            return _ctx.Files;
        }

        public FileModel GetById(int id)
        {
            return GetAll().Where(file => file.Id == id)
                .First();
        }

        public IEnumerable<FileModel> GetByRole(string role)
        {
            return _ctx.Files.Where(f => f.Role == role);
               
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

        public async Task SetFile(string name,  string about, string path, string icon, string role)
        {
            var file = new FileModel
            {
                Name = name,
                About = about,
                Path = path,
                Icon = icon,
                Role = role
            };
            _ctx.Files.Add(file);
            await _ctx.SaveChangesAsync();
        }

    }
}
