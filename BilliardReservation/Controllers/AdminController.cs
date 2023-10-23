using Microsoft.AspNetCore.Mvc;


namespace BilliardReservation.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsersAdmin()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public ActionResult AddRole()
        {
            return View();
        }

        public IActionResult ReservationReport()
        {
            return View();
        }
    }
}
