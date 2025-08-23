
using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Irepos
{
    public interface IAuctionRepository
    {
        Task<Auction> GetByIdAsync(int id);
        Task<IEnumerable<Auction>> GetAllAsync();
        Task StartAuctionAsync(int carId, DateTime startTime, DateTime endTime);
        Task EndAuctionAsync(int auctionId);
        Task PlaceBidAsync(int auctionId, int userId, decimal amount);

        Task<IEnumerable<Auction>> GetActiveAuctionsAsync();
    }
}
