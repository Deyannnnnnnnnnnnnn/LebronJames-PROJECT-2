using Microsoft.AspNetCore.Mvc;

namespace LebronJames_PROJECT_2.Controllers
{
    public class HomeController : Controller
    {
        // Начална страница
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Зарежда Views/Home/Index.cshtml
        }

        // Галерия
        [HttpGet]
        public IActionResult Gallery()
        {
            return View(); // Зарежда Views/Home/Gallery.cshtml
        }

        // Изтегляния
        [HttpGet]
        public IActionResult Downloads()
        {
            return View(); // Зарежда Views/Home/Downloads.cshtml
        }

        // Контакт
        [HttpGet]
        public IActionResult Contact()
        {
            return View(); // Зарежда Views/Home/Contact.cshtml
        }

        // Поверителност
        [HttpGet]
        public IActionResult Privacy()
        {
            return View(); // Зарежда Views/Home/Privacy.cshtml
        }
    }
}
