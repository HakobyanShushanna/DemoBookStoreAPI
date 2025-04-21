namespace DemoBookStoreAPI.DTOs
{
    public class OrderBookDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string BookId { get; set; }
        public int Count { get; set; }
    }
}
