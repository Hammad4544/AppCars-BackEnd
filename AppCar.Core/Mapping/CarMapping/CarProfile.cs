using AppCar.Core.features.Car.Commands.DTOs;
using AppCar.Core.features.Car.Commands.Models;
using AppCar.Core.features.Car.Queries.DTOS;
using AppCar.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.Mapping.CarMapping
{
    public class CarProfile : Profile
    {
        public CarProfile() {

            CreateMap<CAR, DisplayListOfCars>()
                .ForMember(dest => dest.StatusOfCar, opt => opt.MapFrom(src => src.Status));
            CreateMap<CAR, DisplayCar>().
                ForMember(dest => dest.StatusOfCar, opt => opt.MapFrom(src => src.Status));
            CreateMap<AddNewCar, CAR>();
            CreateMap<CAR, AddNewCar>();
            CreateMap<CreateNewCar, CAR>();

        }
    }
}
