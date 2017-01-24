using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers);
        }
        //Get Create - send the View with the little boxes
        [HttpGet]
        public ActionResult Create()
        {
            return View(); // Show the little boxes(form)
        }
        //Post Create -work with the model to update the database with data
        [HttpPost]
        public ActionResult Create(Customer myCustomer)
        {
            //Add the new customet to my set of customers
            db.Customers.Add(myCustomer);
            //Update 
            db.SaveChanges();
            
            return View("Index",db.Customers); //Show the updated Index page
        }
    }
}