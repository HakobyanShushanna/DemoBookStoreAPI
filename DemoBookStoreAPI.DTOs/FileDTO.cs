namespace DemoBookStoreAPI.DTOs
{
    public class FileDTO
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public string Name { get; set; }
    }
}
