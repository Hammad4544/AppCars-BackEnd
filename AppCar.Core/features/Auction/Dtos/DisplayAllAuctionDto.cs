using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Dtos
{
    public class DisplayAllAuctionDto
    {
        public int AuctionId { get; set; }
        public string Title { get; set; } 
        public string Type { get; set; }  
        public string LOC { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
