using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCar.Data.Entities;


namespace AppCar.infrustructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
            
        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Auction> Auctions { get; set; } = null!;
        public DbSet<AuctionCar> AuctionCars { get; set; } = null!;
        public DbSet<Bid> Bids { get; set; } = null!;
        public DbSet<CarOwnershipHistory> CarOwnershipHistories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<CAR> Cars { get; set; } = null!;



    }
}
