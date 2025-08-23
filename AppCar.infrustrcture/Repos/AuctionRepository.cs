using AppCar.Data.Entities;
using AppCar.infrustrcture.Irepos;
using AppCar.infrustructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Repos
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly ApplicationDBContext _db;

        public AuctionRepository(ApplicationDBContext dBContext ) {
          _db=dBContext;

        }
        public async Task EndAuctionAsync(int auctionId)
        {
            var auction = await _db.Auctions.SingleOrDefaultAsync(a => a.AuctionId == auctionId);
            if (auction != null)
            {
                auction.EndDate = DateTime.UtcNow;
                _db.Auctions.Update(auction);
            }
        }

        public async Task<IEnumerable<Auction>> GetActiveAuctionsAsync()
        {
         return  await _db.Auctions.Where(a => a.EndDate > DateTime.Now).ToListAsync();
        }

        public async Task<IEnumerable<Auction>> GetAllAsync()
        {
           return await _db.Auctions.ToListAsync();
        }

        public Task<Auction> GetByIdAsync(int id)
        {
            return _db.Auctions.SingleOrDefaultAsync(a => a.AuctionId == id);
        }

        public Task PlaceBidAsync(int auctionId, int userId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Task StartAuctionAsync(int carId, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }
    }
}
