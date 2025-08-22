using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Data.Entities
{
    public class Bid
    {
        public int BidId { get; set; }
        public decimal Amount { get; set; }
        public DateTime BidDate { get; set; } = DateTime.UtcNow;

        public int AuctionId { get; set; }
        public Auction Auction { get; set; } = null!;

        //public int UserId { get; set; }
        //public User User { get; set; } = null!;
    }

}
