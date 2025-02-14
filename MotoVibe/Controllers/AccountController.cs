using System;
using System.Linq;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Account/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // GET: Account/SignUp
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: Account/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // Example: If you want to create a new user_account too, 
                // you might need to do so before creating the Customer record.
                // For now, let's assume you just store the new Customer.
                db.Customers.Add(customer);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }

        [HttpPost] // Only handles POST requests
        public ActionResult Login(string username, string password, bool rememberMe = false)
        {
            // Query the user_account table
            var user = db.UserAccounts
                         .FirstOrDefault(u => u.Email == username && u.Password == password);

            // Check if username and password are valid
            if (user != null)
            {
                // For real apps, you'd typically set an auth cookie or session
                // For now, just redirect to Home as a placeholder
                return RedirectToAction("Index", "Home");
            }

            // If login fails, return to login page with an error message
            ViewBag.Error = "Invalid username or password";
            return View();
        }
    }
}
