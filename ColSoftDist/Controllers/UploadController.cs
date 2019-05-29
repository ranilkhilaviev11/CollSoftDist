using ColSoftDist.Models;
using DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace ColSoftDist.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UploadController : Controller
    {
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;
        IFile _fileService;
        private readonly RoleManager<IdentityRole> _roleManager;


        public UploadController(ApplicationContext context, IHostingEnvironment appEnvironment, IFile fileService, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _fileService = fileService;
            _roleManager = roleManager;
        }

        public IActionResult Upload()
        {
            var model = new FileUploadViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadNewFile(IFormFile uploadedFile, string name, string about, bool IsStaff)
        {
            if (uploadedFile != null)
            {
                string fileName = name + Path.GetExtension(uploadedFile.FileName);
                // путь к папке Files
                string path = "/Files/" + fileName;
                string icon = "/images/archive_icon.jpg";
                string role;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);

                }
                var rolelist = _roleManager.Roles.ToList();

                if (IsStaff)
                {
                    role = "Staff";
                }
                else 
                {
                    role = "Manager";
                }

               await _fileService.SetFile(fileName, about, path, icon, role);
                
            }
            return RedirectToAction("Index", "Home");
        }
    }
}