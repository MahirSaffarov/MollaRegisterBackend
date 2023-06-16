using Microsoft.AspNetCore.Mvc;

namespace Molla.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}