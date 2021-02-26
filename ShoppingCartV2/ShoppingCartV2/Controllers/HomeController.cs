using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "The Pizza Spot";

        // Text for Order View Heading
        string orderHeading = "Menu";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Pizza ", "Desserts", "Drinks",

                                         "Check-Out", "Admin", "About" };
        

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "Pizza Orders","Desserts", "Drinks",
                                       "Check-Out", "Admin", "About" };
        

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1Orders","Tab2Orders", "Tab3Orders",
                                       "CheckOut", "Admin", "About" };
        

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Pizza Options",
                                              "", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/pizzaspot.jpg\">";
            ViewBag.Message2 += "<br />This is a Pizza Shop that'll leave you speachless. !";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message = "<img src=\"/Images/aboutus.jpg\">";
            ViewBag.Message2 = "Hello! Welcome to the Pizza Spot. We are a local Pizza shop. We were established by a local family who love giving back to the community with this, we have decided that portions of the profits will be redirected to local food banks that help underprivilaged families and individuals. ";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Tab1Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab1Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

        public ActionResult Tab2Orders()
        {
            return GetTabView(2);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab2Orders(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }

        public ActionResult Tab3Orders()
        {
            return GetTabView(3);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab3Orders(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }

    }
}