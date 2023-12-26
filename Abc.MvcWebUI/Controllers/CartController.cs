using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;

namespace Abc.MvcWebUI.Controllers
{
    public class CartController : Controller
    {

        private DataContext db = new DataContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int Id)
        {

            var product=db.Products.Where(i=>i.Id==Id).FirstOrDefault();   
            if(product !=null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
        }
       

        public ActionResult RemoveFromCart(int Id)
        {
            var urun = db.Products.FirstOrDefault(i => i.Id == Id);

            if (urun != null)
            {
                GetCart().DeleteProduct(urun);
            }

            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            var cart = (Cart) Session["Cart"];
            if(cart==null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;

        }
    }
}