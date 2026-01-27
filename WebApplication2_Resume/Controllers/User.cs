using Microsoft.AspNetCore.Mvc;

namespace WebApplication2_Resume.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Experience()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
