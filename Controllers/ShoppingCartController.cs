using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicWEB.Models;

namespace ElectronicWEB.Controllers
{
    
    public class ShoppingCartController : Controller
    {
        //DienTuModel db = new DienTuModel();
        //// GET: ShoppingCart
        //public ActionResult Add(int id)
        //{
        //    ShoppingCart cart = (ShoppingCart)Session["cart"];//loi sesion ra
        //    if(cart==null)
        //    {
        //        cart = new ShoppingCart();//kiem tra xem loi sesion co null ko
        //    }
        //    //truy van csdl hang theo id tu bang sanpham

        //    SANPHAM sp = db.SANPHAMs.Find(id);

        //    cart.InsertItem(sp.TenSP, sp.MaSP, (float)sp.Gia);
        //    Session["cart"] = cart;
        //    return Redirect(Request.UrlReferrer.ToString());
        //}
        //public ActionResult Cart()
        //{
        //    return View();
        //}
    }
}