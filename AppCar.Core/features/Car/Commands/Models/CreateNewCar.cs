using AppCar.Core.features.Car.Commands.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Car.Commands.Models
{
    public class CreateNewCar:IRequest<AddNewCar>
    {
        public string? Brand { get; set; } 
        public string? Model { get; set; } 
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
    }
}
