using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialTestimonials()
        {
            var deger = db.Tbl_Testimonials.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialAbout()
        {
            var deger = db.Tbl_About.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialSkills()
        {
            var deger = db.Tbl_Skills.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialServices()
        {
            var deger = db.Tbl_Services.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialContact()
        {
            var deger = db.Tbl_Contact.ToList();
            return PartialView(deger);
        }
        [HttpGet]
        public ActionResult PartialMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public PartialViewResult PartialEducation()
        {
            var deger = db.Tbl_Education.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialJob()
        {
            var deger = db.Tbl_Job.ToList();
            return PartialView(deger);
        }
           public PartialViewResult PartialProject()
        {
            var deger = db.Tbl_Project.ToList();
            return PartialView(deger);
        }
    }
}