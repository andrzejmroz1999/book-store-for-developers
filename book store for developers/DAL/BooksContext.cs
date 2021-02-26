using book_store_for_developers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace book_store_for_developers.DAL
{
    public class BooksContext : DbContext
    {
        public BooksContext() : base("BooksContext")
        {

        }

        static BooksContext()
        {
            Database.SetInitializer<BooksContext>(new BooksInitializer());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}