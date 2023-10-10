using Microsoft.AspNetCore.Mvc;

namespace AspLesson8._2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Work1()
        {
            return View();
        }

        public IActionResult Work2()
        {
            return View();
        }
    }
}
