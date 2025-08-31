using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface IBidService
    {
        Task<Bid> GetById(int id);
        Task<IEnumerable<Bid>> GetByAuction(int auctionId);
        Task AddBid(Bid bid);
    }
}
