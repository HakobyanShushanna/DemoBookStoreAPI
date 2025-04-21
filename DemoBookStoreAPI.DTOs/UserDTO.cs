namespace DemoBookStoreAPI.DTOs
{
    public class UserDTO
    {
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public List<int> ReviewIds { get; set; } = new List<int>();
        public List<int> OrderIds { get; set; } = new List<int>();
        public DateTimeOffset DoB { get; set; }
        public List<int> VoteAwardIds { get; set; } = new List<int>();
        public List<int> FundedPollIds { get; set; } = new List<int>();
        public List<int> CreatedPollIds { get; set; } = new List<int>();
        public List<int> CreatedAwardIds { get; set; } = new List<int>();
        public List<int> FundedAwardIds { get; set; } = new List<int>();
    }
}
