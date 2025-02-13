using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class ReviewController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Review/Create
        public ActionResult Create(int motorbikeId)
        {
            ViewBag.MotorbikeId = motorbikeId;
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Details", "Motorbike", new { id = review.Motorbike_id });
            }
            return View(review);
        }
    }
}
