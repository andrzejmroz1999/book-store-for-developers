using book_store_for_developers.DAL;
using book_store_for_developers.Infrastructure;
using book_store_for_developers.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace book_store_for_developers.Controllers
{
    public class CartController : Controller
    {
        private CartMenager cartMenager;
        private ISessionMenager sessionMenager { get; set; }
        private BooksContext db;

        public CartController()
        {
            db = new BooksContext();
            sessionMenager = new SessionMenager();
            cartMenager = new CartMenager(sessionMenager, db);
        }
        // GET: Cart
        public ActionResult Index()
        {
            var cartItems = cartMenager.DownloadCart();
            var totalPrice = cartMenager.DownloadCartValue();
            CartViewModel cartVM = new CartViewModel()
            {
                CartItem = cartItems,
                TotalPrice = totalPrice
            };
            return View(cartVM);
        }
        public ActionResult AddToCart(int id)
        {
            cartMenager.AddToCart(id);

            return RedirectToAction("Index");
        }

        public int DownloadNumberOfCartItems()
        {
            return cartMenager.DownloadQuantityOfCartItems();
        }

        public ActionResult RemoveFromCart(int bookId)
        {
            int numberOfItems = cartMenager.RemoveFromCart(bookId);
            int numberOfCartItems = cartMenager.DownloadQuantityOfCartItems();
            decimal cartValue = cartMenager.DownloadCartValue();

            var result = new CartRemovalViewModel
            {
                IdItemsToRemove = bookId,
                NumberItemsToRemove = numberOfItems,
                CartTotalPrice = cartValue,
                CartQuantityItem = numberOfCartItems
            };
            return Json(result);


        }

    }
}