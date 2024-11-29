using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
