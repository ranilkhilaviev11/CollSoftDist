using ColSoftDist.Models;
using DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using DAL.Models;
using System.Security.Claims;
using System.Collections.Generic;

namespace ColSoftDist.Controllers
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class HomeController : Controller
    {
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;
        private readonly IFile _fileService;
        private IHostingEnvironment _hostingEnv;
        UserManager<User> _userManager;

        public HomeController(ApplicationContext context, IHostingEnvironment appEnvironment, IFile fileService, IHostingEnvironment hostingEnv, UserManager<User> userManager)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _fileService = fileService;
            _hostingEnv = hostingEnv;
            _userManager = userManager;

        }



        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            var user = await _userManager.FindByEmailAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);
            var role = roles.First();
            if (User.Identity.IsAuthenticated)
            {
                if (role == "Manager" || role == "Admin")
                {
                    IEnumerable<FileModel> fileList = _fileService.GetAll();
                    var model = new FileIndexViewModel()
                    {

                        Files = fileList

                    };
                    return View(model);
                }
                else if (role == "Staff")
                {
                    IEnumerable<FileModel> fileList = _fileService.GetByRole("Staff");
                    var model = new FileIndexViewModel()
                    {

                        Files = fileList

                    };
                    return View(model);
                }
                else { return NoContent(); }

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