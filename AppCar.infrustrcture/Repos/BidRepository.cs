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
    public class BidRepository : IBidRepository
    {
        private readonly ApplicationDBContext _db;

        public BidRepository(ApplicationDBContext dBContext) {
        _db=dBContext;
        }
        public async Task AddBidAsync(Bid bid)
        {
         
            await _db.Bids.AddAsync(bid);
        }

        public async Task<IEnumerable<Bid>> GetByAuctionAsync(int auctionId)
        {
            return await _db.Bids.Where(b => b.AuctionId == auctionId).ToListAsync();
        }

        public Task<Bid> GetByIdAsync(int id)
        {
           return _db.Bids.SingleOrDefaultAsync(b => b.BidId == id);
        }
    }
}
