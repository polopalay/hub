using Microsoft.AspNetCore.Mvc;

namespace Signal.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class HubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
