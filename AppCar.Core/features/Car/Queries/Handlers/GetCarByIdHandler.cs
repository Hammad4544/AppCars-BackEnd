using AppCar.Core.features.Car.Queries.DTOS;
using AppCar.Core.features.Car.Queries.Models;
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
    public class GetCarByIdHandler : IRequestHandler<GetCarQuery, DisplayCar>
    {
        private readonly IUnitOfWork _unit;
        private IMapper _mapper;

        public GetCarByIdHandler(IUnitOfWork unit , IMapper mapper)
        {
            _unit= unit;
            _mapper = mapper;

        }
        public async Task<DisplayCar> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            var car = await _unit.Cars.GetByIdAsync(request.Id);
            return _mapper.Map<DisplayCar>(car);
        }
    }
}
