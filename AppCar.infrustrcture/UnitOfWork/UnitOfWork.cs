using AppCar.infrustrcture.Irepos;
using AppCar.infrustructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public IProductRepository Products { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IAuctionRepository Auctions { get; private set; }
        public IBidRepository Bids { get; private set; }
        public INotificationRepository Notifications { get; private set; }

        public UnitOfWork(
            ApplicationDBContext context,
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            IOrderRepository orderRepository,
            IAuctionRepository auctionRepository,
            IBidRepository bidRepository,
            INotificationRepository notificationRepository)
        {
            _context = context;
            Products = productRepository;
            Categories = categoryRepository;
            Orders = orderRepository;
            Auctions = auctionRepository;
            Bids = bidRepository;
            Notifications = notificationRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
