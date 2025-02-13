using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserAccount user)
        {
            // Implement login logic here, such as verifying user credentials
            return RedirectToAction("Index", "Home");
        }

        // GET: Account/SignUp
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
                // Save customer data here
                return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }
    }
}
