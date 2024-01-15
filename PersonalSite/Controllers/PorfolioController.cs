using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DungeonDweller () 
        {
            return View();
        }

        public IActionResult IntroToMVC ()
        {
            return View();
        }
    }
}
