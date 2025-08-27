using AppCar.Data.Entities;
using AppCar.infrustrcture.UnitOfWork;
using AppCar.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<Product> Add(Product product)
        {
          await _unitOfWork.Products.AddAsync(product);
           await _unitOfWork.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Delete(int id)
        {
            
            var product = await  _unitOfWork.Products.GetByIdAsync(id);
            if (product == null) return null;
           await _unitOfWork.Products.DeleteAsync(product.ProductId);
           await _unitOfWork.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<IEnumerable<Product>> GetByCategory(int categoryId)
        {
           
           return await _unitOfWork.Products.GetByCategoryAsync(categoryId);
        }

        public async Task<Product> GetByIdA(int id)
        {
           
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> Search(string keyword)
        {
           
            return await _unitOfWork.Products.SearchAsync(keyword);
        }

        public async Task<Product> Update(int id)
        {

            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null) return null;
            await _unitOfWork.Products.UpdateAsync(product.ProductId);
           await _unitOfWork.SaveChangesAsync();
            return product;
        }
    }
}
