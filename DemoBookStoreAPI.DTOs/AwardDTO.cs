namespace DemoBookStoreAPI.DTOs
{
    public class Award
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> FunderIds {  get; set; } = new List<string>();
        public string AuthorId { get; set; }
        public DateTimeOffset Date { get; set; }
        public string CreatorId { get; set; }
    }
}
