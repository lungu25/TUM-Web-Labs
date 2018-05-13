using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.BusinessLogic.DbModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    [Authorize]
    public class SmartphoneController : Controller
    {
        private ApplicationDbContext _db;

        public SmartphoneController()
        {
            _db = new ApplicationDbContext();
        }



        // GET: Smartphone
        public ActionResult Index()
        {
            var model = _db.Smartphones.ToList();

            return View(model);
        }

        public ActionResult Details(Smartphone smartphone)
        {
            return View(smartphone);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }

    }
}