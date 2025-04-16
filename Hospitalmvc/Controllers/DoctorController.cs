using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class DoctorController : Controller
    {
        // GET: /Doctor/Dashboard
        public IActionResult Dashboard()
        {
            var appointments = new[]
            {
                new { Id = 1, DateTime = "2025-05-02T09:00", Patient = "John Doe" },
                new { Id = 2, DateTime = "2025-05-02T11:30", Patient = "Jane Smith" }
            };

            return View(appointments);
        }
    }
}
