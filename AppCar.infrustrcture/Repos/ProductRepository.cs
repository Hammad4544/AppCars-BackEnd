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
    public class ProductRepository : IProductRepository 
    {
        private readonly ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext dBContext)
        {
            _db = dBContext;
        }
        public async Task AddAsync(Product product)
        {
           await _db.Products.AddAsync(product);
        }

        public  async Task DeleteAsync(int id)
        {
            var product = await _db.Products.SingleOrDefaultAsync(p => p.ProductId == id);
            if (product != null)
            {
                _db.Products.Remove(product);
            }

        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
          return await  _db.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId)
        {
          return  await _db.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _db.Products.SingleOrDefaultAsync(p => p.ProductId == id)!;  
        }

        public async Task<IEnumerable<Product>> SearchAsync(string keyword)
        {
           return await _db.Products.Where(p => p.Name.Contains(keyword) || p.Description.Contains(keyword)).ToListAsync();
        }

        
        public  Task UpdateAsync(Product product)
        {
            _db.Products.Update(product);
            return Task.CompletedTask;
        }
    }
}
