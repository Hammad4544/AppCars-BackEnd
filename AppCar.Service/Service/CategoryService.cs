using AppCar.Data.Entities;
using AppCar.infrustrcture.Irepos;
using AppCar.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.Service
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;

        }
        public Task Add(Category category)
        {
            return _repo.AddAsync(category);
        }

        public Task Delete(int id)
        {
           return _repo.DeleteAsync(id);
        }

        public Task<IEnumerable<Category>> GetAll()
        {
            return _repo.GetAllAsync();
        }

        public Task<Category> GetById(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task Update(Category category)
        {
           return _repo.UpdateAsync(category);
        }
    }
}
