using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Signal.Signal;

namespace Signal.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class HubController : Controller
    {
        public IHubContext<ChatHub> _hubContext { get; set; }
        public HubController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }
        public IActionResult Index()
        {
            _hubContext.Clients.All.SendAsync("1", "demo");
            return View();
        }
    }
}
