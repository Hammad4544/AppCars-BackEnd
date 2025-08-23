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
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDBContext _db;

        public CarRepository(ApplicationDBContext dBContext) {
        
            _db = dBContext;
        }

        public async Task AddAsync(CAR car)
        {
          await  _db.Cars.AddAsync(car);
        }

        public async Task DeleteAsync(int id)
        {
            
            var car = await _db.Cars.SingleOrDefaultAsync(c=>c.CarId==id);
            if (car != null)
            {
                _db.Cars.Remove(car);
            }
        }

        public async Task<IEnumerable<CAR>> GetAllAsync()
        {
            return await _db.Cars.ToListAsync();
        }

        public async Task<CAR> GetByIdAsync(int id)
        {
            return await _db.Cars.SingleOrDefaultAsync(c => c.CarId == id);
        }

        public Task<IEnumerable<CAR>> GetByUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CAR>> SearchAsync(string keyword)
        {
           return  _db.Cars.Where(c => c.Brand.Contains(keyword) || c.Model.Contains(keyword)).AsEnumerable();
        }

        public Task UpdateAsync(CAR car)
        {
            return Task.Run(() => _db.Cars.Update(car));
        }
    }
}
