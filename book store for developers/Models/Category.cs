using System.Collections.Generic;

namespace book_store_for_developers.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescyption{ get; set; }
        public string IconFileName { get; set; }
        
        
        public virtual ICollection<Book> Books { get; set; }
    }
}