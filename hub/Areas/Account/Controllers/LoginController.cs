using Microsoft.AspNetCore.Mvc;
using Signal.Models;

namespace Signal.Areas.Identity.Controllers
{
    [Area("Account")]
    public class LoginController : Controller
    {
        [BindProperty]
        public LoginModel Model { get; set; }
        public IActionResult Index()
        {
            Model = new LoginModel();
            return View(Model);
        }
        [HttpPost]
        public IActionResult Submit()
        {
            return View();
        }
    }
}
