using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface ICarService
    {
        Task<CAR> GetById(int id);
        Task<IEnumerable<CAR>> GetAll();
        Task<CAR> Add(CAR car);
        Task<CAR> Update(CAR car);
        Task<CAR> Delete(int id);

        // Business
        IEnumerable<CAR> GetByUser(int userId);  // العربيات بتاعة يوزر معين
        Task<IEnumerable<CAR>> Search(string keyword); // بحث بالاسم/الموديل
    }
}
