using AppCar.Core.features.Car.Queries.DTOS;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Car.Queries.Models
{
    public class GetCarQuery : IRequest<DisplayCar>
    {
        public int Id { get; set; }
        public GetCarQuery(int id) {
            Id = id;
        }
    }
}
