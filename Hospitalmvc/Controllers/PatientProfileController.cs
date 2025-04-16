using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class PatientProfileController : Controller
    {
        // GET: /Profile
        public IActionResult Index()
        {
            return View(); // PatientProfile.cshtml (frontend)
        }

        // POST: /Profile (update profile logic here if needed)
        [HttpPost]
        public IActionResult Index(string name, string email, string phone, string address)
        {
            // Simulate saving updated profile (future backend logic)
            Console.WriteLine("Profile updated");
            return View(); // Return the view with updated profile
        }
    }
}
