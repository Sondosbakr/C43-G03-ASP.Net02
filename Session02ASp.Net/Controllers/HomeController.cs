using Microsoft.AspNetCore.Mvc;
using Session02ASp.Net.Models;

namespace Session02ASp.Net.Controllers
{
    public class HomeController : Controller
    {
        //BaseURL/Home/Index
        public IActionResult Index()
        {
            ///return View("hamada", new Movie());
            ///return View("Hamada");
            ///return View(new Movie()); 

            return View();// Return View With The Same Name Of Action
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
