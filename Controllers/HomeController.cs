using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono l'action Index del controller Home");
        }
    }
}
