using System;
using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/About
        public ActionResult About()
        {
            return View();
        }

        // GET: Home/Contact
        public ActionResult Contact()
        {
            return View();
        }

        // GET: Home/Blog
        public ActionResult Blog()
        {
            var blogs = db.Blogs.ToList();
            return View(blogs);
        }

        // GET: Home/BlogDetails
        /*public ActionResult BlogDetails(int id)
        {
            // Adjust 'b.BlogId' if your Blog model property is named differently
            var blog = db.Blogs.FirstOrDefault(b => b.BlogId == id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }*/

        // GET: Home/SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: Home/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Home/Listproduct
        public ActionResult Listproduct()
        {
            var products = db.Motorbikes.ToList();  // Ensure you have a DbSet<Motorbike> in AppDbContext
            return View(products);
        }

        // GET: Home/CustomerProfile
        public ActionResult CustomerProfile(int id)
        {
            // Use 'CustomerId' (the C# property name), not 'Customer_id'
            var customer = db.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}
