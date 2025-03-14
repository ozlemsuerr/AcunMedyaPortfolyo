using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;
namespace AcunMedyaPortfolyo.Controllers
{
    public class MessageController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        // GET: Message
        public ActionResult Index()
        {
            var deger = db.Tbl_Message.ToList();
            return View(deger);
        }
        public ActionResult RemoveMessage(int id)
        {
            var deger = db.Tbl_Message.Find(id);
            db.Tbl_Message.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var deger = db.Tbl_Message.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateMessage(Tbl_Message model6)
        {
            var deger = db.Tbl_Message.Find(model6.MessageID);
            deger.NameSurname = model6.NameSurname;
            deger.Mail = model6.Mail;
            deger.Subject = model6.Subject;
            deger.Massage = model6.Massage;
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}