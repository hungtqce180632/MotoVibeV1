using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        // List Warranty Page
        public ActionResult ListWarranty()
        {
            var warranties = db.Warranties
                              .Include(w => w.Order)
                              .ToList();
            return View(warranties);
        }

        public ActionResult CreateAppointment()
        {
            return View();
        }

        // Employee Profile Page
        public ActionResult EmployeeProfile(int employeeId)
        {
            var employee = db.Employees
                           .Include(e => e.UserAccount)
                           .FirstOrDefault(e => e.Employee_id == employeeId);
            return View(employee);
        }

        // View List Order Page
        public ActionResult ViewListOrder()
        {
            var orders = db.Orders
                         .Include(o => o.Customer)
                         .Include(o => o.Motorbike)
                         .ToList();
            return View(orders);
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        // Manage Review Page
        public ActionResult ManageReview()
        {
            var reviews = db.Reviews
                          .Include(r => r.Customer)
                          .Include(r => r.Motorbike)
                          .ToList();
            return View(reviews);
        }

        public ActionResult ManageFeedback()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        
        //test
        public ActionResult ProductList()
        {
            return View();
        }

        // Product List Page (Motorbikes)
        public ActionResult Listproduct()
        {
            var motorbikes = db.Motorbikes
                              .Include(m => m.Brand)
                              .Include(m => m.Model)
                              .Include(m => m.Fuel)
                              .ToList();
            return View(motorbikes);
        }

        // Product Detail Page (Motorbike)
        public ActionResult Detailproduct(int productId)
        {
            var motorbike = db.Motorbikes
                            .Include(m => m.Brand)
                            .Include(m => m.Model)
                            .Include(m => m.Fuel)
                            .FirstOrDefault(m => m.Motorbike_id == productId);
            return View(motorbike);
        }

        // Blog List Page
        public ActionResult Blog()
        {
            var blogs = db.Blogs
                       .Include(b => b.Admin)
                       .Where(b => b.Blog_status)
                       .ToList();
            return View(blogs);
        }

        // Blog Details Page
        public ActionResult detaiblog(int blogId)
        {
            var blog = db.Blogs
                      .Include(b => b.Admin)
                      .FirstOrDefault(b => b.Blog_id == blogId);
            return View(blog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}