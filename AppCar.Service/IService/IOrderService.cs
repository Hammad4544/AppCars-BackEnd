using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface IOrderService
    {
        Task<Order> GetById(int id);
        Task<IEnumerable<Order>> GetAllByUser(int userId);
        Task Add(Order order);
        Task Update(Order order);
        void Delete(int id);
    }
}
