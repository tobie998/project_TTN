using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;
using System.Data.Entity;


namespace ElectronicWEB.Controllers
{
    public class AdminController : Controller
    {
        DienTuModel db = new DienTuModel();
        public ActionResult Index()
        {
            return View(db.ADMINS.ToList());
        }
        public ActionResult Create()
        {
            ViewBag.MaNV = new SelectList(db.NHANVIENs, "MaNV", "TenNV");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ADMIN ad)
        {
            if (ModelState.IsValid)
            {
                db.ADMINS.Add(ad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNV = new SelectList(db.NHANVIENs, "MaNV", "TenNV", ad.MaNV);
            return View(ad);
        }
        public ActionResult Delete(int id)
        {
            ADMIN ad = db.ADMINS.Find(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            return View(ad);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ADMIN ad = db.ADMINS.Find(id);
            db.ADMINS.Remove(ad);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            ADMIN ad = db.ADMINS.Find(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            return View(ad);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ADMIN ad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ad);
        }
        public ActionResult Details(int id)
        {
            ADMIN ad = db.ADMINS.Find(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            return View(ad);
        }
    }
}