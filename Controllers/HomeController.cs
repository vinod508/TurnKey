using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TurnKey.Models;

namespace TurnKey.Controllers
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
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult OurServices()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Conceptualization()
        {
            return View();
        }
        public IActionResult Engineering()
        {
            return View();
        }
        public IActionResult Manufacturing()
        {
            return View();
        }
        public IActionResult ProjectExecutionandValidation()
        {
            return View();
        }
        public IActionResult ProjectManagement()
        {
            return View();
        }
        public IActionResult AirHandlingDetails()
        {
            return View();
        }
        public IActionResult AirWasherDetails()
        {
            return View();
        }
        public IActionResult CleanroomDoorsDetails()
        {
            return View();
        }
        public IActionResult CleanroomModularDetails()
        {
            return View();
        }
        public IActionResult ProcessChillersDetails()
        {
            return View();
        }
        public IActionResult AirDistributionProducts()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
