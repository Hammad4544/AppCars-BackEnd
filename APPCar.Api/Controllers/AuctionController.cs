using AppCar.Core.features.Auction.Commands.Models;
using AppCar.Core.features.Auction.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APPCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuctionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAllAuction")]
        public async Task<ActionResult> GetAll() { 
        
            var result = await _mediator.Send(new GetAllAuctionQuery());
            return Ok(result);
        }
        [HttpGet("GetAuctionById")]
        public async Task<ActionResult> GetAuctionById(int id) { 
        
            var result = await _mediator.Send(new GetAuctionByIdQuery(id));
            return Ok(result);
        
        
        }
        [HttpPost("CreateNewAuction")]
        public async Task<ActionResult> CreateNewAuction([FromBody] AddNewAuctionQuery newAuction) { 
        
            var result = await _mediator.Send(newAuction);
            return Ok(result);
        }
        [HttpGet("GetActiveAuctions")]
        public async Task<ActionResult> GetActiveAuctions() { 
        
            var result = await _mediator.Send(new GetActiveAuctionQuery());
            if (result == null) { 
            
                return NotFound();
            }
            return Ok(result);
        }
    }
}
