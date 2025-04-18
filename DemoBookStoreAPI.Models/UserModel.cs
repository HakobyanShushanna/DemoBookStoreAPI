namespace BookShop.Models
{
    public class UserModel : PersonModel
    {
        public List<ReviewModel> Reviews { get; set; } = new List<ReviewModel>();
        public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
        public int Age { get; set; }
        public string Address { get; set; }
        public List<PollModel> Voted { get; set; } = new List<PollModel>();
        public List<PollModel> FundedPolls { get; set; } = new List<PollModel>();
        public List<PollModel> CreatedPolls { get; set; } = new List<PollModel>();
        public List<AwardModel> CreatedAwards { get; set; } = new List<AwardModel>();
        public List<AwardModel> FundedAwards { get; set; } = new List<AwardModel>();
    }
}
