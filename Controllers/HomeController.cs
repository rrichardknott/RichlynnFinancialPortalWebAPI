using RichlynnFinancialPortalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichlynnFinancialPortalWebAPI.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        private ApiDbContext db = new ApiDbContext();
        
        /// <summary>
        /// Home controller / index action
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //public ActionResult TestConnection()
        //{
        //    return View(db.Households.ToList());
        //}
    }
}
