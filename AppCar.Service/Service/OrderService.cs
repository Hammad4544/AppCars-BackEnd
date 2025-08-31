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
    internal class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo ) { _repo = repo; }
        public Task Add(Order order)
        {
            return _repo.AddAsync( order );
        }

        public void Delete(int id)
        {
            _repo.DeleteAsync( id );
        }

        public Task<IEnumerable<Order>> GetAllByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetById(int id)
        {
           return _repo.GetByIdAsync( id );
        }

        public Task Update(Order order)
        {
            return _repo.UpdateAsync(order) ;
        }
    }
}
