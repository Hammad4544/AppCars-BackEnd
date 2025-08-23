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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDBContext _db;

        public CategoryRepository(ApplicationDBContext dBContext ) {
            _db = dBContext;
        }
        public async Task AddAsync(Category category)
        {
            await _db.Categories.AddAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
           var category = await _db.Categories.SingleOrDefaultAsync(c => c.CategoryId == id);
            if (category != null)
            {
                _db.Categories.Remove(category);
            }
            
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
          return  await _db.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
           return await _db.Categories.SingleOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task UpdateAsync(Category category)
        {
             _db.Categories.Update(category);
        }
    }
}
