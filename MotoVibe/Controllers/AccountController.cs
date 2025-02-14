using System;
using System.Web.Mvc;
using MotoVibe.Models;

namespace MotoVibe.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
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
        [HttpPost] // Chỉ nhận POST request
        public ActionResult Login(string username, string password, bool rememberMe = false)
        {
            // Kiểm tra xem username và password có hợp lệ không
            if (username == "admin@example.com" && password == "123456")
            {
                // Lưu thông tin đăng nhập vào session hoặc cookie nếu rememberMe = true
                Session["User"] = username;

                if (rememberMe)
                {
                    Response.Cookies["User"].Value = username;
                    Response.Cookies["User"].Expires = DateTime.Now.AddDays(7); // Cookie lưu trong 7 ngày
                }

                // Chuyển hướng đến trang Dashboard hoặc HomePage
                return RedirectToAction("Index", "Home");
            }

            // Nếu đăng nhập thất bại, quay lại trang login và báo lỗi
            ViewBag.Error = "Invalid username or password";
            return View();
        }
    }
}
