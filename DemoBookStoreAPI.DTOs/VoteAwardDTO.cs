namespace DemoBookStoreAPI.DTOs
{
    public class VoteAwardDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> FunderIds { get; set; } = new List<string>();
        public List<int> VoteIds { get; set; } = new List<int>();
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public string CreatorId { get; set; }
        public List<string> VotedUserIds { get; set; } = new List<string>();
    }
}
