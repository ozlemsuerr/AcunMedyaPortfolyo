using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace AcunMedyaPortfolyo.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            ViewBag.test = "";
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            ViewBag.test = "";
            ViewBag.TestimonialsCount = db.Tbl_Testimonials.Count();
            ViewBag.test = "";
            ViewBag.ProjectsCount = db.Tbl_Project.Count();
            ViewBag.test = "";
            ViewBag.SkillsCount = db.Tbl_Skills.OrderByDescending(x => x.SkillsID).FirstOrDefault();
            ViewBag.test = "";
            ViewBag.TestimonialsCount1 = db.Tbl_Testimonials.OrderBy(x => x.TestimonialsID).FirstOrDefault();
            ViewBag.test = "";
            ViewBag.ProjectsCount1 = db.Tbl_Project.OrderBy(x => x.ProjectID).FirstOrDefault();

            return View();
        }
    }
}