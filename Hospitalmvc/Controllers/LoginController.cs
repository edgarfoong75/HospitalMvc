using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        public IActionResult Index()
        {
            return View(); // This will search for Views/Account/Login.cshtml
        }

        // POST: /Login
        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            if (email == "patient@example.com" && password == "password")
            {
                return RedirectToAction("Index", "Profile"); // Redirect to Profile if login is successful
            }

            ViewData["LoginError"] = "Invalid login credentials."; // Display error on invalid login
            return View(); // Return the Login view with error message
        }
    }
}
