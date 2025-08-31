using AppCar.Data.Entities;
using AppCar.infrustrcture.Irepos;
using AppCar.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.Service
{
    public class BidService : IBidService
    {
        private readonly IBidRepository _repo;

        public BidService(IBidRepository repo)
        {
          _repo= repo;
        }
        public Task AddBid(Bid bid)
        {
           return _repo.AddBidAsync(bid);
        }

        public Task<IEnumerable<Bid>> GetByAuction(int auctionId)
        {
            return _repo.GetByAuctionAsync(auctionId);
        }

        public Task<Bid> GetById(int id)
        {
            return _repo.GetByIdAsync(id);
        }
    }
}
