using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Abc.MvcWebUI.Entity;

namespace Abc.MvcWebUI.Controllers
{
    /*public class AdminController : Controller
    {
    //  GET: Admin
    Context _context = new Context();
    [Authorize]
    public ActionResult Index()
    {
      var degerler = _context.Blogs.ToList();
       return View(degerler);
    }
    public ActionResult BlogSil(int id)
    {
       var b = _context.Blogs.Find(id);
       _context.Blogs.Remove(b);
       _context.SaveChanges();
       return RedirectToAction("Index");
      }
       public ActionResult BlogGetir(int id)
        {
        var bl = _context.Blogs.Find(id);
        return View("BlogGetir", bl);
      }
    }*/
}