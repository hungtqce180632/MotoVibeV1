using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class MotorbikeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Motorbike
        public ActionResult Index()
        {
            var motorbikes = db.Motorbikes.ToList();
            return View(motorbikes);
        }

        // GET: Motorbike/Details/5
        public ActionResult Details(int id)
        {
            var motorbike = db.Motorbikes.FirstOrDefault(m => m.Motorbike_id == id);
            if (motorbike == null)
            {
                return HttpNotFound();
            }
            return View(motorbike);
        }

        // GET: Motorbike/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motorbike/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Motorbike motorbike)
        {
            if (ModelState.IsValid)
            {
                db.Motorbikes.Add(motorbike);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorbike);
        }
    }
}
