using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;
using PagedList;

namespace ElectronicWEB.Controllers
{
    public class SanPhamController : Controller
    {
        private DienTuModel db = new DienTuModel();

        // GET: SanPham
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var sANPHAMs = (from l in db.SANPHAMs
                            select l).OrderBy(x => x.TenSP);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(sANPHAMs.ToPagedList(pageNumber, pageSize));
        }

        // GET: SanPham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaSP = new SelectList(db.GIOHANGs, "MaSP", "MaSP");
            ViewBag.MaHSX = new SelectList(db.HANG_SX, "MaHSX", "TenHSX");
            ViewBag.MaLH = new SelectList(db.LOAIHANGs, "MaLH", "TenLH");
            return View();
        }

        // POST: SanPham/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSP,TenSP,Gia,NgaySX,TinhTrang,Photo,MaLH,MaHSX")] SANPHAM sANPHAM, HttpPostedFileBase UploadImage)
        {
            if (ModelState.IsValid)
            {
                if (UploadImage != null)
                {
                    if (UploadImage.ContentType == "image/jpg" || UploadImage.ContentType == "image/png" || UploadImage.ContentType == "image/jpeg")

                    {
                        UploadImage.SaveAs(Server.MapPath("/") + "/Content/" + UploadImage.FileName);
                        sANPHAM.Photo = UploadImage.FileName;
                    }

                    else return View();
                }
                else
                    return View();
                db.SANPHAMs.Add(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSP = new SelectList(db.GIOHANGs, "MaSP", "MaSP", sANPHAM.MaSP);
            ViewBag.MaHSX = new SelectList(db.HANG_SX, "MaHSX", "TenHSX", sANPHAM.MaHSX);
            ViewBag.MaLH = new SelectList(db.LOAIHANGs, "MaLH", "TenLH", sANPHAM.MaLH);
            return View(sANPHAM);
        }

        // GET: SanPham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSP = new SelectList(db.GIOHANGs, "MaSP", "MaSP", sANPHAM.MaSP);
            ViewBag.MaHSX = new SelectList(db.HANG_SX, "MaHSX", "TenHSX", sANPHAM.MaHSX);
            ViewBag.MaLH = new SelectList(db.LOAIHANGs, "MaLH", "TenLH", sANPHAM.MaLH);
            return View(sANPHAM);
        }

        // POST: SanPham/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSP,TenSP,Gia,NgaySX,TinhTrang,Photo,MaLH,MaHSX")] SANPHAM sANPHAM, HttpPostedFileBase UploadImage)
        {
            if (ModelState.IsValid)
            {
                if (UploadImage != null)
                {
                    if (UploadImage.ContentType == "image/jpg" || UploadImage.ContentType == "image/png" || UploadImage.ContentType == "image/jpeg")

                    {
                        UploadImage.SaveAs(Server.MapPath("/") + "/Content/" + UploadImage.FileName);
                        sANPHAM.Photo = UploadImage.FileName;
                    }

                    else return View();
                }
                else
                    return View();
                db.Entry(sANPHAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSP = new SelectList(db.GIOHANGs, "MaSP", "MaSP", sANPHAM.MaSP);
            ViewBag.MaHSX = new SelectList(db.HANG_SX, "MaHSX", "TenHSX", sANPHAM.MaHSX);
            ViewBag.MaLH = new SelectList(db.LOAIHANGs, "MaLH", "TenLH", sANPHAM.MaLH);
            return View(sANPHAM);
        }

        // GET: SanPham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(sANPHAM);
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
