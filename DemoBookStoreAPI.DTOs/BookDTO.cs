namespace DemoBookStoreAPI.DTOs
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string>? AuthorIds { get; set; } = new List<string>();
        public string Genre { get; set; }
        public List<int>? ReviewIds { get; set; } = new List<int>();
        public decimal Price { get; set; }
        public bool IsElectronicAvailable { get; set; }
        public bool IsAvailable { get; set; }
        public int? AgeRestriction { get; set; }
        public List<int>? OrderBookIds { get; set; } = new List<int>();
        public int fileId { get; set; }
        public List<string>? FormerAuthorIds { get; set; } = new List<string>();
    }
}
