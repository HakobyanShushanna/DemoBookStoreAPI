namespace DemoBookStoreAPI.DTOs
{
    public class AuthorRegisterDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTimeOffset DoB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
