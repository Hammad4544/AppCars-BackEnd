using AppCar.Core.features.Car.Queries.DTOS;
using AppCar.Core.features.Car.Queries.Models;
using AppCar.Data.Entities;
using AppCar.infrustrcture.UnitOfWork;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Car.Queries.Handlers
{
    public class CarHandler : IRequestHandler<GetCarListQuery, List<DisplayListOfCars>>
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public CarHandler(IUnitOfWork unitOfWork ,IMapper mapper)
        {
            _unit = unitOfWork;
            _mapper = mapper;

        }
        

        async Task<List<DisplayListOfCars>> IRequestHandler<GetCarListQuery, List<DisplayListOfCars>>.Handle(GetCarListQuery request, CancellationToken cancellationToken)
        {
            var CarList = await _unit.Cars.GetAllAsync();
            return _mapper.Map<List<DisplayListOfCars>>(CarList);

        }

    }
}
