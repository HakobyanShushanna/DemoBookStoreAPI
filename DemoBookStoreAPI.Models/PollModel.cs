using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class PollModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<UserModel> Funders { get; set; } = new List<UserModel>();
        public List<VoteOptionModel> Votes { get; set; } = new List<VoteOptionModel>();
        public DateTime Date { get; set; }
        public DateTime End { get; set; }
        public UserModel Creator { get; set; } = new UserModel();
        public List<UserModel> VotedUsers { get; set; } = new List<UserModel>();
    }
}
