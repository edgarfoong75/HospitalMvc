using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: /Admin/Dashboard
        public IActionResult Dashboard()
        {
            var appointments = new[]
            {
                new { Id = 1, DateTime = "2025-05-02T09:00", Doctor = "Dr. Smith", Patient = "John Doe" },
                new { Id = 2, DateTime = "2025-05-03T11:30", Doctor = "Dr. Johnson", Patient = "Jane Smith" }
            };

            var users = new[]
            {
                new { Id = 1, Name = "John Doe", Role = "Patient" },
                new { Id = 2, Name = "Dr. Smith", Role = "Doctor" },
                new { Id = 3, Name = "Jane Smith", Role = "Patient" }
            };

            var model = new { Appointments = appointments, Users = users };
            return View(model);
        }
    }
}
