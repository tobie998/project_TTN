using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ElectronicWEB.Models;

namespace ElectronicWEB.Controllers
{
    public class GioHangController : Controller
    {
        DienTuModel db = new DienTuModel();
        public ActionResult Index()
        {
            return View(db.GIOHANGs.ToList());
        }
        public ActionResult Create()
        {
            ViewBag.MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GIOHANG gh)
        {
            if (ModelState.IsValid)
            {
                db.GIOHANGs.Add(gh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", gh.MaSP);
            return View(gh);
        }
        public ActionResult Delete(int id)
        {
            GIOHANG gh = db.GIOHANGs.Find(id);
            if (gh == null)
            {
                return HttpNotFound();
            }
            return View(gh);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GIOHANG gh = db.GIOHANGs.Find(id);
            db.GIOHANGs.Remove(gh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            GIOHANG gh = db.GIOHANGs.Find(id);
            if (gh == null)
            {
                return HttpNotFound();
            }
            return View(gh);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GIOHANG gh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gh);
        }
        public ActionResult Details(int id)
        {
            GIOHANG gh = db.GIOHANGs.Find(id);
            if (gh == null)
            {
                return HttpNotFound();
            }
            return View(gh);
        }
    }
}