using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace book_store_for_developers.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(string categoryName)
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            return View();
        }
    }
}