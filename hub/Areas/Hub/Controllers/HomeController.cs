using Microsoft.AspNetCore.Mvc;

namespace Signal.Areas.Hub.Controllers
{
    [Area("Hub")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
