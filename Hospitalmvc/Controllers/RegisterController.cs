using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class RegisterController : Controller
    {
        // GET: /Register
        public IActionResult Index()
        {
            return View(); // Register.cshtml (frontend)
        }

        // POST: /Register
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Simulate registration logic
            Console.WriteLine($"Registering user: {username}");
            return RedirectToAction("Index", "Login");  // Redirect to login page after registration
        }
    }
}
