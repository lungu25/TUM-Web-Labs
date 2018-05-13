using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.BusinessLogic.DbModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DataController : Controller
    {


        private StoreDbContext _db;

        public DataController()
        {
            _db = new StoreDbContext();
        }



        // GET: Data
        public ActionResult SmartphoneForm()
        {

            var model = new Smartphone();

            return View(model);
        }



        public ActionResult Save( Smartphone smartphone )
        {
            if (smartphone.Id == 0)
            {
                _db.Smartphones.Add(smartphone);

            }
            else
            {
                var dbSmartphone = _db.Smartphones.Single(m => m.Id == smartphone.Id);
                TryUpdateModel(dbSmartphone);

            }

            _db.SaveChanges();
            

            return RedirectToAction("Index", "Home");
        }

        public ActionResult ShowAllSmartphones()
        {

            var model = _db.Smartphones.ToList();

            return View(model);
        }

        public ActionResult Update(Smartphone smartphone)
        {

            return View("SmartphoneForm", smartphone);
        }

        public ActionResult Delete(Smartphone smartphone)
        {
            var dbSmartphone = _db.Smartphones.Find(smartphone.Id);
            _db.Smartphones.Remove(dbSmartphone);
            _db.SaveChanges();

            return RedirectToAction("ShowAllSmartphones", "Data");
        }


        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }


    }
}