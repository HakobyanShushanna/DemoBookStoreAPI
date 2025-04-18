namespace BookShop.Models
{
    public class AuthorModel : PersonModel
    {
        public List<BookModel> Books { get; set; } = new List<BookModel>();
        public List<AwardModel> Awards { get; set; } = new List<AwardModel>();
        public double AverageScore { get; set; }
    }
}
