namespace DemoBookStoreAPI.DTOs
{
    public class AuthorDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTimeOffset DoB {  get; set; }
        public List<int> BookIds { get; set; } = new List<int>();
        public List<int> AwardIds { get; set; } = new List<int>();
        public double AverageScore { get; set; }
    }
}
