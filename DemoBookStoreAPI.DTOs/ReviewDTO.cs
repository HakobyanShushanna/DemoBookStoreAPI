namespace DemoBookStoreAPI.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Stars { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        public string Description { get; set; }
    }
}
