using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface IAuctionService
    {
        Task<Auction> GetById(int id);
        Task<IEnumerable<Auction>> GetAll();
        Task StartAuction(int carId, DateTime startTime, DateTime endTime);
        Task EndAuction(int auctionId);
        Task PlaceBid(int auctionId, int userId, decimal amount);

        Task<IEnumerable<Auction>> GetActiveAuctions();
    }
}
