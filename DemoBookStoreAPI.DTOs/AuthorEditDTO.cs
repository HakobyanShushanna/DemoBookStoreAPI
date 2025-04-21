namespace DemoBookStoreAPI.DTOs
{
    public class AuthorEditDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTimeOffset DoB { get; set; }
    }
}
