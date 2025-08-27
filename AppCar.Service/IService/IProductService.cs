using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface IProductService
    {

        // Define product-related service methods here

        Task<Product> GetByIdA(int id);
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Add(Product product);
        Task<Product> Update(int id);
        Task<Product> Delete(int id);

        // Business
        Task<IEnumerable<Product>> GetByCategory(int categoryId);
        Task<IEnumerable<Product>> Search(string keyword);
    }
}
