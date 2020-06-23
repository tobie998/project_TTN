using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;
using System.Data.Entity;

namespace ElectronicWEB.Controllers
{
    public class ClientController : Controller
    {
        DienTuModel db = new DienTuModel();
        public ActionResult Index()
        {
            return View(db.CLIENTS.ToList());
        }
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KHACHHANGs, "MaKH", "TenKH");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CLIENT cl)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTS.Add(cl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KHACHHANGs, "MaKH", "TenKH", cl.MaKH);
            return View(cl);
        }
        public ActionResult Delete(int id)
        {
            CLIENT cl = db.CLIENTS.Find(id);
            if (cl == null)
            {
                return HttpNotFound();
            }
            return View(cl);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CLIENT cl = db.CLIENTS.Find(id);
            db.CLIENTS.Remove(cl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            CLIENT cl = db.CLIENTS.Find(id);
            if (cl == null)
            {
                return HttpNotFound();
            }
            return View(cl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CLIENT cl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cl);
        }
        public ActionResult Details(int id)
        {
            CLIENT cl = db.CLIENTS.Find(id);
            if (cl == null)
            {
                return HttpNotFound();
            }
            return View(cl);
        }
    }
}