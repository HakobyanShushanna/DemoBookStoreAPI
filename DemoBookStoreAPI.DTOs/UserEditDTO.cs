namespace DemoBookStoreAPI.DTOs
{
    public class UserEditDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTimeOffset DoB { get; set; }
    }
}
