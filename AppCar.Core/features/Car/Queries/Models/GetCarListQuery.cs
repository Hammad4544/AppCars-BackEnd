using AppCar.Core.features.Car.Queries.DTOS;
using AppCar.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Car.Queries.Models
{
    public class GetCarListQuery : IRequest<List<DisplayListOfCars>>
    {

    }
}
