using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var deger = db.Tbl_About.ToList();
            return View(deger);
        }
        public ActionResult RemoveAbout(int id)
        { var deger = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
             }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(Tbl_About about)
        {
            db.Tbl_About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var deger = db.Tbl_About.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateAbout(Tbl_About model2)
        {
            var deger = db.Tbl_About.Find(model2.AboutID);
            deger.Description = model2.Description; 
            deger.ImageURL = model2.ImageURL;
            deger.Title = model2.Title;
            deger.Description2 = model2.Description2;
            deger.Birthday = model2.Birthday;
            deger.Website = model2.Website;
            deger.Phone = model2.Phone;
            deger.Age = model2.Age;
            deger.City = model2.City;
            deger.Degree = model2.Degree;
            deger.Email = model2.Email;
            deger.Freelance = model2.Freelance;
         
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}