using book_store_for_developers.DAL;
using book_store_for_developers.Models;
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
           var CategoryList = db.Categories.ToList();
           // var BooksList = db.Books.ToList();

            return View();
        }
    } 
}