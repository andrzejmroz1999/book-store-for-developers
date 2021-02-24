using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace book_store_for_developers.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public  string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal OrderValue { get; set; }

        List<OrderItem> OrderItems { get; set; }

    }
    public enum OrderStatus
    {
        New,
        Realized
    }
}