namespace DemoBookStoreAPI.DTOs
{
    public class FormerAuthorDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> BookIds { get; set; } = new List<string>();
    }
}
