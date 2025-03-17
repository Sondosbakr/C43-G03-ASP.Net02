using Microsoft.AspNetCore.Mvc;

namespace Session02ASp.Net.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
