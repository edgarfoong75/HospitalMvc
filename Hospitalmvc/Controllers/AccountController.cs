using Hospitalmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();  // Return the login view
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Placeholder login logic (replace with actual authentication logic)
                if (model.Email == "patient@example.com" && model.Password == "password")
                {
                    return RedirectToAction("Index", "Home"); // Redirect to the Home page after successful login
                }

                // If login fails, display an error message
                ViewData["LoginError"] = "Invalid login credentials.";
            }

            return View();
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();  // Return the register view
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Placeholder register logic (replace with actual user registration logic)
                if (model.Password == model.ConfirmPassword)
                {
                    // Simulate successful registration
                    return RedirectToAction("Login");  // Redirect to login after successful registration
                }

                ViewData["RegisterError"] = "Passwords do not match.";
            }

            return View();
        }
    }
}
