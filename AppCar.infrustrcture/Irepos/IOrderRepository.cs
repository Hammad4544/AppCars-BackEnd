using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Irepos
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(int id);
        Task<IEnumerable<Order>> GetAllByUserAsync(int userId);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        void DeleteAsync(int id);
    }
}
