using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var deger = db.Tbl_Slider.ToList();
            return View(deger);
        }
        public ActionResult RemoveSlider(int id)
        {
            var deger = db.Tbl_Slider.Find(id);
            db.Tbl_Slider.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSlider(Tbl_Slider slider)
        {
            db.Tbl_Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var deger = db.Tbl_Slider.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateSlider(Tbl_Slider model10)
        {
            var deger = db.Tbl_Slider.Find(model10.SliderID);
            deger.NameSurname = model10.NameSurname;
            deger.Description = model10.Description;
            deger.ImageURL = model10.ImageURL;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}