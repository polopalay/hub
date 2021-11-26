using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Signal.Signal;
using System.Threading.Tasks;

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
