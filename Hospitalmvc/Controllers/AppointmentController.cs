using Microsoft.AspNetCore.Mvc;

namespace Hospitalmvc.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: /Appointment/Schedule
        public IActionResult Schedule()
        {
            return View(); // AppointmentScheduling.cshtml
        }

        // GET: /Appointment/ManageAppointments
        public IActionResult ManageAppointments()
        {
            return View(); // AppointmentManagement.cshtml
        }
    }
}
