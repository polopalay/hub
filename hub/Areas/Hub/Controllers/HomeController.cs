using Microsoft.AspNetCore.Mvc;

namespace hub.Areas.Hub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
