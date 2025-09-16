using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Dtos
{
    public class CreateAuctionDto
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Location { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; } 
    }
}
