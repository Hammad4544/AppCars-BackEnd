using AppCar.Data.Entities;
using AppCar.infrustrcture.Irepos;
using AppCar.infrustrcture.UnitOfWork;
using AppCar.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCar.Service.Service
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CAR> Add(CAR car)
        {
            await _unitOfWork.Cars.AddAsync(car);
            await _unitOfWork.SaveChangesAsync();
            return car;
        }

        
        public async Task<CAR> Delete(int id)
        {
            var car = await _unitOfWork.Cars.GetByIdAsync(id);
            if (car == null) return null;

            _unitOfWork.Cars.DeleteAsync(car.CarId);
            await _unitOfWork.SaveChangesAsync();
            return car;
        }

        
        public async Task<IEnumerable<CAR>> GetAll()
        {
            return await _unitOfWork.Cars.GetAllAsync();
        }

        
        public async Task<CAR> GetById(int id)
        {
            return await _unitOfWork.Cars.GetByIdAsync(id);
        }

        
        public IEnumerable<CAR> GetByUser(int userId)
        {
            
            return _unitOfWork.Cars.GetByUserAsync(userId).Result;
        }

       
        public async Task<IEnumerable<CAR>> Search(string keyword)
        {
            return await _unitOfWork.Cars.SearchAsync(keyword);
        }

        
        public async Task<CAR> Update(CAR car)
        {
            _unitOfWork.Cars.UpdateAsync(car);
            await _unitOfWork.SaveChangesAsync();
            return car;
        }
    }
}
