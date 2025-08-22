using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Data.Entities
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = "Private"; // Government, Private
        public string Location { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; } = string.Empty;

        //public int CreatedById { get; set; }
        //public User CreatedBy { get; set; } = null!;

        // Relations
        public ICollection<AuctionCar> AuctionCars { get; set; } = new List<AuctionCar>();
        public ICollection<Bid> Bids { get; set; } = new List<Bid>();
    }

}
