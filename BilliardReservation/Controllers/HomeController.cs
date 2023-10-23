using BilliardReservation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BilliardReservation.Controllers
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

        public IActionResult Reservation() {
            
            return View();
        }

        public IActionResult Administrator()
        {
            return View();
        }

        public IActionResult Signin() {
            return View();
        }

        public IActionResult Signup() {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //For Click Button Submit Adminnistrator
        public IActionResult OnPostGoToAnotherPage()
        {
            // Redirect to another page or route
            return RedirectToPage("/Signin"); // Example using Razor Pages
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}