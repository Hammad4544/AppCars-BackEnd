using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Data.Entities
{
    public class CAR
    {
        [Key]
        public int CarId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Available"; // Available, Sold
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relations
        //public int OwnerId { get; set; }
        //public User Owner { get; set; } = null!;
        public ICollection<CarOwnershipHistory> OwnershipHistory { get; set; } = new List<CarOwnershipHistory>();
        public ICollection<AuctionCar> AuctionCars { get; set; } = new List<AuctionCar>();
    }
}
