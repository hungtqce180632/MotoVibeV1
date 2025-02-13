using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class AppointmentController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Appointment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appointment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                db.Appointments.Add(appointment);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(appointment);
        }

        // GET: Appointment/Details/5
        public ActionResult Details(int id)
        {
            var appointment = db.Appointments.FirstOrDefault(a => a.Appointment_id == id);
            if (appointment == null)
            {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // GET: Appointment/Manage
        public ActionResult Manage()
        {
            var appointments = db.Appointments.ToList();
            return View(appointments);
        }
    }
}
