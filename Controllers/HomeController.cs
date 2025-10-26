using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to Lab5! My name is Igor Wambyakaley.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
