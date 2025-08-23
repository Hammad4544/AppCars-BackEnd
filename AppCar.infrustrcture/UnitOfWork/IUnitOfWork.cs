using AppCar.infrustrcture.Irepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        IAuctionRepository Auctions { get; }
        IBidRepository Bids { get; }
        INotificationRepository Notifications { get; }

        Task<int> SaveChangesAsync();
    }

}
