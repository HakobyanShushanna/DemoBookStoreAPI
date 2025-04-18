using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class VoteOptionModel
    {
        public int Id { get; set; }
        public int Counts { get; set; }
        public AuthorModel Author { get; set; } = new AuthorModel();
    }
}
