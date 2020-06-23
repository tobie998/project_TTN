using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;
using System.Data.Entity;
using PagedList;


namespace ElectronicWEB.Controllers
{
    public class KhachHangController : Controller
    {
        DienTuModel db = new DienTuModel();
        // GET: KhachHang
        public ActionResult Index(int? page)
        {
            //return View(db.KHACHHANGs.ToList());

            // 1. Tham số int? dùng để thể hiện null và kiểu int
            // page có thể có giá trị là null và kiểu int.

            // 2. Nếu page = null thì đặt lại là 1.
            if (page == null) page = 1;

            // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
            // theo LinkID mới có thể phân trang.
            var links = (from l in db.KHACHHANGs
                         select l).OrderBy(x => x.MaKH);

            // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
            int pageSize = 3;

            // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            int pageNumber = (page ?? 1);

            // 5. Trả về các Link được phân trang theo kích thước và số trang.
            return View(links.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KHACHHANG kh)
        {
            if (ModelState.IsValid)
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kh);
        }
        public ActionResult Delete(int id)
        {
            KHACHHANG kh = db.KHACHHANGs.Find(id);
            if (kh == null)
            {
                return HttpNotFound();
            }
            return View(kh);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KHACHHANG kh = db.KHACHHANGs.Find(id);
            db.KHACHHANGs.Remove(kh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            KHACHHANG kh = db.KHACHHANGs.Find(id);
            if (kh == null)
            {
                return HttpNotFound();
            }
            return View(kh);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KHACHHANG kh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kh);
        }
        public ActionResult Details(int id)
        {
            KHACHHANG kh = db.KHACHHANGs.Find(id);
            if (kh == null)
            {
                return HttpNotFound();
            }
            return View(kh);
        }
    }
}