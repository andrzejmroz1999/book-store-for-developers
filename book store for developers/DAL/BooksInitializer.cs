using book_store_for_developers.Migrations;
using book_store_for_developers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace book_store_for_developers.DAL
{
    public class BooksInitializer : MigrateDatabaseToLatestVersion<BooksContext,Configuration>
    {      
        public static void SeedBooksData(BooksContext context)
        {
            var categories = new List<Category>
            {
                new Category() {CategoryId=1,CategoryName="Programming", IconFileName="programing.png",CategoryDescyption="Books for programmers"},
                new Category() {CategoryId=2,CategoryName="Office applications", IconFileName="officeApplications.png",CategoryDescyption="Books for office workers"},
                new Category() {CategoryId=3,CategoryName="Database", IconFileName="database.png",CategoryDescyption="Books for database specialists"},
                new Category() {CategoryId=4,CategoryName="Networks and servers", IconFileName="networksAndServers.png",CategoryDescyption="Books for networkers and administrators"},
                new Category() {CategoryId=5,CategoryName="Security", IconFileName="security.png",CategoryDescyption="Books about application security"},
                new Category() {CategoryId=6,CategoryName="Computer Graphics", IconFileName="computerGraphics.png",CategoryDescyption="Books for graphic designers"},
                new Category() {CategoryId=7,CategoryName="Others", IconFileName="Others.jpg",CategoryDescyption="Other books"},
            };

            categories.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            var books = new List<Book>
            {
              new Book() {BookId = 1, BookAuthor="Prata Stephen",BookTitle="Język C++. Szkoła programowania",CategoryId=1,BookPrice=64,ReleaseDate=Convert.ToDateTime("05-05-2020"),DateAdded=DateTime.Now,Bestseller =true,ImageFileName="jezykCpp.jpg"},
              new Book() {BookId = 2,BookAuthor="Schildt Herbert",BookTitle="Java. Przewodnik dla początkujących",CategoryId=1,BookPrice=72,ReleaseDate=Convert.ToDateTime("05-05-2020"),DateAdded=DateTime.Now,Bestseller=true,ImageFileName="java.jpg"},
              new Book() {BookId = 3,BookAuthor="Grolemund Garrett",BookTitle="Język R. Kompletny zestaw narzędzi dla analityków danych",CategoryId=1,BookPrice=59,ReleaseDate=Convert.ToDateTime("2020-08-04"),DateAdded=DateTime.Now,Bestseller=true,ImageFileName="jezykR.jpg"},
              new Book() {BookId = 4,BookAuthor="Matthes Eric",BookTitle="Python. Instrukcje dla programisty",CategoryId=1,BookPrice=64,ReleaseDate=Convert.ToDateTime("05-05-2020"),DateAdded=DateTime.Now,Bestseller=true,ImageFileName="python.jpg"},
            };
            books.ForEach(k => context.Books.AddOrUpdate(k));
            context.SaveChanges();

        }
    }
}
