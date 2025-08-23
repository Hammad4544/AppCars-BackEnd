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
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _db;
        public OrderRepository(ApplicationDBContext dBContext)
        {
            _db = dBContext;
        }
        public async Task AddAsync(Order order)
        {
            await _db.Orders.AddAsync(order);
        }

        public void DeleteAsync(int id)
        {
            var order = _db.Orders.SingleOrDefault(o => o.OrderId == id);
            if (order != null)
            {
                _db.Orders.Remove(order);
            }

        }

        public Task<IEnumerable<Order>> GetAllByUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
           return await _db.Orders.SingleOrDefaultAsync(o=>o.OrderId==id);
        }

        public async Task UpdateAsync(Order order)
        {
            await Task.Run(() => _db.Orders.Update(order));
        }
    }
}
