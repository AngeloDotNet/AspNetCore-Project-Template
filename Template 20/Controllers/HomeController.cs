using Microsoft.AspNetCore.Mvc;

namespace Template_SqlServer_AdoNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Benvenuto!";
            return View();
        }
    }
}