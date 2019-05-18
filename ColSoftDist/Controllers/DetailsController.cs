using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ColSoftDist.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace ColSoftDist.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IFile _fileService;

        public DetailsController(IFile fileService)
        {
            _fileService = fileService;
        }

        public IActionResult Index(int id)
        {
            var file = _fileService.GetById(id);

            var model = new FileDetailViewModel()
            {
                Id = file.Id,
                Name = file.Name,
                Url = file.Icon,
                About = file.About,
                Posts = file.Roles.Select(t => t.Name).ToList()
            };
            return View(model);
        }

        public VirtualFileResult GetVirtualFile(string fileName)
        {
            var filepath = Path.Combine("~/Files", fileName);
            return File(filepath, "multipart/form-data", fileName);
        }
    }
}