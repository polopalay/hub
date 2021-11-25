using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Signal.Models;
using System.Threading.Tasks;

namespace Signal.Areas.Identity.Controllers
{
    [Area("Account")]
    public class RegisterController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public RegisterController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            RegisterModel model = new RegisterModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return LocalRedirect("/");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }
    }
}
