using book_store_for_developers.DAL;
using book_store_for_developers.Models;
using book_store_for_developers.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace book_store_for_developers.Controllers
{
    public class HomeController : Controller
    {
        private BooksContext db = new BooksContext();
        public ActionResult Index()
        {
            var categories = db.Categories.ToList();
            var latests = db.Books.Where(a => !a.Hidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
            var bestsellers = db.Books.Where(a => !a.Hidden && a.Bestseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();

            var vm = new HomeViewModel()
            {
                Cagegories = categories,
                Latests = latests,
                Bestsellers = bestsellers
            };
           

            return View(vm);
        }
        public ActionResult StaticPages(string name)
        {
            return View(name);
        }
    } 
}