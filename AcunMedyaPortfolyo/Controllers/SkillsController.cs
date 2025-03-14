using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var deger = db.Tbl_Skills.ToList();
            return View(deger);
        }
        public ActionResult RemoveSkills(int id)
        {
            var deger = db.Tbl_Skills.Find(id);
            db.Tbl_Skills.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateSkills()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkills(Tbl_Skills skills)
        {
            db.Tbl_Skills.Add(skills);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkills(int id)
        {
            var deger = db.Tbl_Skills.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateSkills(Tbl_Skills model9)
        {
            var deger = db.Tbl_Skills.Find(model9.SkillsID);
            deger.Description = model9.Description;
            deger.SkillsName = model9.SkillsName;
            deger.Derece = model9.Derece;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}