using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
