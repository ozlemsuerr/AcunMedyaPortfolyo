using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
   
    public class ContactController : Controller
    {
        // GET: Contact
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var deger = db.Tbl_Contact.ToList();
            return View(deger);
        }
        public ActionResult RemoveContact(int id)
        {
            var deger = db.Tbl_Contact.Find(id);
                db.Tbl_Contact.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(Tbl_Contact contact)
        {
            db.Tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var deger = db.Tbl_Contact.Find(id);
            return View(deger);
            
        }
        [HttpPost]
        public ActionResult UpdateContact(Tbl_Contact model3)
        {
            var deger = db.Tbl_Contact.Find(model3.ContactID);
            deger.Address = model3.Address;
            deger.Email = model3.Email;
            deger.Phone = model3.Phone;
            deger.Description = model3.Description;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}