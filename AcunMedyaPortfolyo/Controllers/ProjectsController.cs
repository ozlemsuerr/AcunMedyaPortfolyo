using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var deger = db.Tbl_Project.ToList();
            return View(deger);
        }
        public ActionResult RemoveProjects(int id)
        {
            var deger = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Tbl_Project project)
        {
            db.Tbl_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProjects(int id)
        {
            var deger = db.Tbl_Project.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateProjects(Tbl_Project model7)
        {
            var deger = db.Tbl_Project.Find(model7.ProjectID);
            deger.ProjectName = model7.ProjectName;
            deger.Description = model7.Description;
            deger.ProjectLink = model7.ProjectLink;
            deger.Image1 = model7.Image1;
            deger.Image2 = model7.Image2;
            deger.Image3 = model7.Image3;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}