using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface ICategoryService
    {
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> GetAll();
        Task Add(Category category);
        Task Update(Category category);
        Task Delete(int id);
    }
}
