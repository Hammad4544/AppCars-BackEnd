using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Irepos
{
    public interface IBidRepository
    {
        Task<Bid> GetByIdAsync(int id);
        Task<IEnumerable<Bid>> GetByAuctionAsync(int auctionId);
        Task AddBidAsync(Bid bid);
    }
}
