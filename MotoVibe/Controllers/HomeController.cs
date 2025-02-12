using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotoVibe.Controllers
{
    public class HomeController : Controller
    {
        // Default Home Page
        public ActionResult Index()
        {
            return View();
        }

        // About Page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        // Contact Page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        // List Warranty Page
        public ActionResult ListWarranty()
        {
            // You can implement logic to get warranty data here if needed
            return View();
        }

        // Create Appointment Page
        public ActionResult CreateAppointment()
        {
            // Logic for creating an appointment can go here
            return View();
        }

        // Employee Profile Page
        public ActionResult EmployeeProfile()
        {
            // Logic for displaying employee profile can go here
            return View();
        }

        // View List Order Page
        public ActionResult ViewListOrder()
        {
            // Logic for listing orders can be added here
            return View();
        }

        // Create Order Page
        public ActionResult CreateOrder()
        {
            // Logic for creating an order can go here
            return View();
        }

        // Manage Review Page
        public ActionResult ManageReview()
        {
            // Logic for managing reviews can go here
            return View();
        }

        // Manage Feedback Page
        public ActionResult ManageFeedback()
        {
            // Logic for managing feedback can go here
            return View();
        }

        // Login Page
        public ActionResult Login()
        {
            return View();
        }

        // Product List Page
        public ActionResult Listproduct()
        {
            // Logic for displaying product list can go here
            return View();
        }

        // Product Detail Page
        public ActionResult Detailproduct(int productId)  // Assuming you're passing the product ID
        {
            // Retrieve product details based on ID, if needed
            return View();
        }

        // Blog List Page
        public ActionResult Blog()
        {
            // Logic for fetching blog posts goes here
            return View();
        }

        // Blog Details Page
        public ActionResult detaiblog(int blogId)  // Assuming you're passing the blog ID
        {
            // Fetch the details for the specific blog post based on blogId
            return View();
        }

        public ActionResult Search()
        {
            // Logic for fetching blog posts goes here
            return View();
        }
        public ActionResult CreateBlog()
        {
            return View();
        }
        public ActionResult CreateBlog()
        {
            return View();
        }
    }
}
