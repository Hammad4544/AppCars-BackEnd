using AppCar.Core.features.Car.Commands.DTOs;
using AppCar.Core.features.Car.Commands.Models;
using AppCar.Data.Entities;
using AppCar.infrustrcture.UnitOfWork;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Car.Commands.Handlers
{
    public class CreareNewCarHandler : IRequestHandler<CreateNewCar, AddNewCar>
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public CreareNewCarHandler(IMapper mapper , IUnitOfWork unit)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public async Task<AddNewCar> Handle(CreateNewCar request, CancellationToken cancellationToken)
        {

            var newCar = _mapper.Map<CAR>(request);
            await _unit.Cars.AddAsync((newCar));
            await _unit.SaveChangesAsync();
            return _mapper.Map<AddNewCar>(newCar);



        }
    }
}
