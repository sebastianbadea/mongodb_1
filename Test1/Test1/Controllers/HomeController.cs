﻿using MongoDB.Driver;
using System.Web.Mvc;
using Test1.Models;
using Test1.Properties;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        readonly MongoDbContext _context;
        public HomeController()
        {
            _context = new MongoDbContext();
        }
        public ActionResult Index()
        {
            var rentals = _context.Rentals.FindAll();

            return View(rentals);
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(PostRental postRental)
        {
            var rental = new Rental(postRental);
            _context.Rentals.Insert(rental);


            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}