namespace DemoBookStoreAPI.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset Date { get; set; }
        public List<int> OrderBookIds { get; set; }
    } 
}
