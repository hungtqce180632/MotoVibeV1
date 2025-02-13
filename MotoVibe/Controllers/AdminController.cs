using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Admin
        public ActionResult AdminDashboard()
        {
            var admins = db.Admins.ToList();
            return View(admins);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("AdminDashboard");
            }
            return View(admin);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            var admin = db.Admins.FirstOrDefault(a => a.Admin_id == id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AdminDashboard");
            }
            return View(admin);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            var admin = db.Admins.FirstOrDefault(a => a.Admin_id == id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var admin = db.Admins.FirstOrDefault(a => a.Admin_id == id);
            db.Admins.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }
    }
}
