using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotoVibe.Controllers
{
    public class HomeController : Controller
    {
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

 
        public ActionResult ListWarranty()
        {
            return View();
        }

        public ActionResult CreateAppointment()
        {
            return View();
        }

        public ActionResult EmployeeProfile()
        {
            return View();
        }

        public ActionResult ViewListOrder()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        public ActionResult ManageReview()
        {
            return View();
        }

        public ActionResult ManageFeedback()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Listproduct()
        {
            return View();
        }
        public ActionResult Detailproduct()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult detaiblog()
        {
            return View();
        }
        public ActionResult CreateBlog()
        {
            return View();
        }
    }
}