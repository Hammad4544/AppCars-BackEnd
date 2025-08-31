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
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository _repo;

        public AuctionService(IAuctionRepository repo)
        {
            _repo = repo;

        }
        public Task EndAuction(int auctionId)
        {
          return  _repo.EndAuctionAsync(auctionId);
        }

        public Task<IEnumerable<Auction>> GetActiveAuctions()
        {
           return _repo.GetActiveAuctionsAsync();
        }

        public Task<IEnumerable<Auction>> GetAll()
        {
            return _repo.GetAllAsync();
        }

        public Task<Auction> GetById(int id)
        {
           return _repo.GetByIdAsync(id);
        }

        public Task PlaceBid(int auctionId, int userId, decimal amount)
        {
           return _repo.PlaceBidAsync(auctionId, userId, amount);
        }

        public Task StartAuction(int carId, DateTime startTime, DateTime endTime)
        {
           return _repo.StartAuctionAsync(carId, startTime, endTime);
        }
    }
}
