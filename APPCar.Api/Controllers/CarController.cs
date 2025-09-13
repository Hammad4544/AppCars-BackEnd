using AppCar.Core.features.Car.Commands.Models;
using AppCar.Core.features.Car.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APPCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator) { 
        
            _mediator = mediator;
        }
        [HttpGet("GetAllCars")]
        public  async Task<IActionResult> GetAllCar() { 
        
            var result = await _mediator.Send(new GetCarListQuery());
            return Ok(result);
        }
        [HttpGet("GetCarById/{id}")]
        public async Task<IActionResult> GetCarById(int id) { 
        
            var result = await _mediator.Send(new GetCarQuery(id));
            return Ok(result);
        }
        [HttpPost("AddNewCar")]
        public async Task<IActionResult> AddNewCar([FromBody] CreateNewCar command) { 
        
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
