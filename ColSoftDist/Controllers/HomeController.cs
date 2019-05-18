using ColSoftDist.Models;
using DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ColSoftDist.Controllers
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class HomeController : Controller
    {
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;
        private readonly IFile _fileService;
        private IHostingEnvironment _hostingEnv;

        public HomeController(ApplicationContext context, IHostingEnvironment appEnvironment, IFile fileService, IHostingEnvironment hostingEnv)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _fileService = fileService;
            _hostingEnv = hostingEnv;
        }



        public IActionResult Index()
        {
            
            if (User.Identity.IsAuthenticated)
            {
                var fileList = _fileService.GetAll();

                var model = new FileIndexViewModel()
                {
                    Files = fileList,
                    SearchQuery = ""

                };
                return View(model);
            }
            else { return RedirectToAction("Login", "Account"); }
           
        }
        

        
        public async Task<IActionResult> OnDeleteAsync(int id)
        {
            await _fileService.DeleteFile(id);

            return RedirectToAction("Index", "Home");
        }

       
    
    }
}