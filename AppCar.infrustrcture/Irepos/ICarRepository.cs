using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Irepos
{
    public interface ICarRepository
    {
        Task<CAR> GetByIdAsync(int id);
        Task<IEnumerable<CAR>> GetAllAsync();
        Task AddAsync(CAR car);
        Task UpdateAsync(CAR car);
        Task DeleteAsync(int id);

        // Business
        Task<IEnumerable<CAR>> GetByUserAsync(int userId);  // العربيات بتاعة يوزر معين
        Task<IEnumerable<CAR>> SearchAsync(string keyword); // بحث بالاسم/الموديل
    }
}
