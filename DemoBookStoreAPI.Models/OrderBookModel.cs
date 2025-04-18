using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class OrderBookModel
    {
        public int Id { get; set; }
        public OrderModel Order { get; set; } = new OrderModel();
        public BookModel Book { get; set; } = new BookModel();
        public int Count { get; set; }
    }
}
