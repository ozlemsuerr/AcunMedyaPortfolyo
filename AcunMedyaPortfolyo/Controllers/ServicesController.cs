using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var deger = db.Tbl_Services.ToList();
            return View(deger);
        }
        public ActionResult RemoveServices(int id)
        {
            var deger = db.Tbl_Services.Find(id);
            db.Tbl_Services.Remove(deger);
                db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateServices(Tbl_Services services)
        {
            db.Tbl_Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var deger = db.Tbl_Services.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateServices(Tbl_Services model8)
        {
            var deger = db.Tbl_Services.Find(model8.ServicesID);
            deger.Title = model8.Title;
            deger.Description = model8.Description;
            deger.Description2 = model8.Description2;
            deger.IconURL = model8.IconURL;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}