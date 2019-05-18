using ColSoftDist.Models;
using DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ColSoftDist.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UploadController : Controller
    {
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;
        IFile _fileService;


        public UploadController(ApplicationContext context, IHostingEnvironment appEnvironment, IFile fileService)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _fileService = fileService;
        }

        public IActionResult Upload()
        {
            var model = new FileUploadViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadNewFile(IFormFile uploadedFile, string name, string about)
        {
            if (uploadedFile != null)
            {
                string fileName = name + Path.GetExtension(uploadedFile.FileName);
                // путь к папке Files
                string path = "/Files/" + fileName;
                string icon = "/images/archive_icon.jpg";
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
               await _fileService.SetFile(fileName, about, path, icon);
                
            }
            return RedirectToAction("Index", "Home");
        }
    }
}