using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class TestimonialsController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        // GET: Testimonials
        public ActionResult Index()
        {
            var deger = db.Tbl_Testimonials.ToList();
            return View(deger);
        }
        public ActionResult RemoveTestimonials(int id)
        {
            var deger = db.Tbl_Testimonials.Find(id);
            db.Tbl_Testimonials.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatTestimonials()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatTestimonials(Tbl_Testimonials testimonials)
        {
            db.Tbl_Testimonials.Add(testimonials);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonials(int id)
        {
            var deger = db.Tbl_Testimonials.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateTestimonials(Tbl_Testimonials model11)
        {
            var deger = db.Tbl_Testimonials.Find(model11.TestimonialsID);
            deger.Description = model11.Description;
            deger.TestimonialsName = model11.TestimonialsName;
            deger.Description2 = model11.Description2;
            deger.ImageURL = model11.ImageURL;
            deger.Title = model11.Title;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}