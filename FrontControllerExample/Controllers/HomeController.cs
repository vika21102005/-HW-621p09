using Microsoft.AspNetCore.Mvc;

namespace FrontControllerExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Login() => View();
    }
}
