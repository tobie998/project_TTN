using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;


namespace ElectronicWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var productDao = new ShoppingCart();
            ViewBag.NewProduct = productDao.ListNewProduct(5);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Admin()
        {
            string us = Request.Form["us"];
            string mk = Request.Form["mk"];

            string u = "admin";
            string m = "admin";

            if (u.Equals(us) && m.Equals(mk))
            {
                return Redirect("http://localhost:52654/SanPham/Index");
            }
            else
            {
                TempData["msg"] = "Tài Khoản Hoặc Mật Khẩu Không Chính Xác";
                return RedirectToAction("/Login");
            }
        }
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult Widgets()
        {
            return View();
        }
        public ActionResult Categories()
        {
            return View();
        }
        public ActionResult SanPham123()
        {
            return View();
        }
    }
}