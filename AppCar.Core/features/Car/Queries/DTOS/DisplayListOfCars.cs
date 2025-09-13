using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Car.Queries.DTOS
{
    public class DisplayListOfCars
    {
        public int CarId { get; set; }
        public string? Brand { get; set; } = string.Empty;
        public string? Model { get; set; } = string.Empty;
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; } 
        public string? StatusOfCar { get; set; } 

    }
}
