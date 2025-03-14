using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class EducationController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        // GET: Education
        public ActionResult Index()
        {
            var deger = db.Tbl_Education.ToList();
            return View(deger);
        }
        public ActionResult RemoveEducation(int id)
        {
            var deger = db.Tbl_Education.Find(id);
            db.Tbl_Education.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(Tbl_Education education)
        {
            db.Tbl_Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var deger = db.Tbl_Education.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Tbl_Education model4)
        {
            var deger = db.Tbl_Education.Find(model4.EducationID);
            deger.StartYear = model4.StartYear;
            deger.EdnYear = model4.EdnYear;
            deger.Name = model4.Name;
            deger.Description = model4.Description;
            deger.Section = model4.Section;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}