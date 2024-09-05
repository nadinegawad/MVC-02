using Microsoft.AspNetCore.Mvc;

namespace MVC_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult privacy()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }

    }
}
