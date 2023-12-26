using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Abc.MvcWebUI.Entity;

namespace Abc.MvcWebUI.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        DataContext _context = new DataContext();
        public ActionResult Index()
        {
            var bloglar = _context.Blogs.ToList();

            return View(bloglar);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = _context.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = _context.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            _context.Yorumlars.Add(y);
            _context.SaveChanges();
            return PartialView();
        }
    }
}