using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var deger = db.Tbl_Job.ToList();
            return View(deger);
        }
        public ActionResult RemoveJob(int id)
        {
            var deger = db.Tbl_Job.Find(id);
            db.Tbl_Job.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateJob(Tbl_Job job)
        {
            db.Tbl_Job.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var deger = db.Tbl_Job.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateJob(Tbl_Job model5)
        {
            var deger = db.Tbl_Job.Find(model5.JobID);
            deger.Title = model5.Title;
            deger.StartYear = model5.StartYear;
            deger.EndYear = model5.EndYear;
            deger.CompanyName = model5.CompanyName;
            deger.Description = model5.Description;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}