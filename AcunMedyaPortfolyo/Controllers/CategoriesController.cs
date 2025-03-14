using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var deger = db.Tbl_Category.ToList();
            return View(deger);
        }
        public ActionResult RemoveCategory(int id)
        {
            var deger = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult CreateCategories()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategories(Tbl_Category category)
        {
            db.Tbl_Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var deger = db.Tbl_Category.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category model1)
        {
            var deger = db.Tbl_Category.Find(model1.CategoryID);
            deger.CategoryName = model1.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}