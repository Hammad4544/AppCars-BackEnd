using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Data.Entities
{
    public class AuctionCar
    {
        public int AuctionCarId { get; set; }
        public int AuctionId { get; set; }
        public Auction Auction { get; set; } = null!;
        public int CarId { get; set; }
        public CAR Car { get; set; } = null!;
        public decimal StartingPrice { get; set; }
        public string Status { get; set; } = "Available"; // Available, Sold
    }

}
