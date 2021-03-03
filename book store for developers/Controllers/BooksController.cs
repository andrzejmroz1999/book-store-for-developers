using book_store_for_developers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace book_store_for_developers.Controllers
{
    public class BooksController : Controller
    {
        private BooksContext db = new BooksContext();
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(string categoryName)
        {
            var category = db.Categories.Include("Books").Where(c => c.CategoryName.ToUpper() == categoryName.ToUpper()).Single();
            var books = category.Books.ToList();
            return View(books);
        }

        public ActionResult Details(string id)
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult CategoriesMenu()
        {
            var categories = db.Categories.ToList();
            return PartialView("_CategoriesMenu",categories);
        }
    }
}