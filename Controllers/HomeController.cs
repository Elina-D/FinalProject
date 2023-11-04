using GroupProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult ManageTask()
        {
            return View("CreateTask");
        }
        public IActionResult Tasks()
        {
            return View("Tasks");
        }
        public IActionResult EditTask()
        {
            return View("EditTask");
        }
        public IActionResult EditProject()
        {
            return View("EditProject");
        }
        public IActionResult CreateProject()
        {
            return View("CreateProject");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}