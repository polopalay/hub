using Microsoft.AspNetCore.Mvc;

namespace Signal.Areas.Hub.Controllers
{
    [Area("Pages")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
