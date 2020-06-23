using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;

namespace ElectronicWEB.Controllers
{
    public class NhanVienController : Controller
    {
        private DienTuModel db = new DienTuModel();

        // GET: NHANVIENs
        public ActionResult Index()
        {
            var nHANVIENs = db.NHANVIENs.Include(n => n.ADMIN);
            return View(nHANVIENs.ToList());
        }

        // GET: NHANVIENs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Create
        public ActionResult Create()
        {
            ViewBag.MaNV = new SelectList(db.ADMINS, "MaNV", "TenLOGIN");
            return View();
        }

        // POST: NHANVIENs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,TenNV,GT,NS,SĐT,photo,Luong")] NHANVIEN nHANVIEN, HttpPostedFileBase UploadImage)
        {
            if (ModelState.IsValid)
            {
                if (UploadImage != null)
                {
                    if (UploadImage.ContentType == "image/jpg" || UploadImage.ContentType == "image/png" || UploadImage.ContentType == "image/jpeg")

                    {
                        UploadImage.SaveAs(Server.MapPath("/") + "/Content/" + UploadImage.FileName);
                        nHANVIEN.photo = UploadImage.FileName;
                    }

                    else return View();
                }
                else
                    return View();
                db.NHANVIENs.Add(nHANVIEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNV = new SelectList(db.ADMINS, "MaNV", "TenLOGIN", nHANVIEN.MaNV);
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNV = new SelectList(db.ADMINS, "MaNV", "TenLOGIN", nHANVIEN.MaNV);
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,TenNV,GT,NS,SĐT,photo,Luong")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHANVIEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNV = new SelectList(db.ADMINS, "MaNV", "TenLOGIN", nHANVIEN.MaNV);
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            db.NHANVIENs.Remove(nHANVIEN);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
