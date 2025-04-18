namespace BookShop.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public UserModel? User { get; set; }
        public DateTime Date { get; set; }
        public List<OrderBookModel> Counts { get; set; } = new List<OrderBookModel>();
    }
}
