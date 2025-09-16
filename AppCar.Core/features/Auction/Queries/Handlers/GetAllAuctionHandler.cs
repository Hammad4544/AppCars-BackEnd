using AppCar.Core.features.Auction.Dtos;
using AppCar.Core.features.Auction.Queries.Models;
using AppCar.Service.IService;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Queries.Handlers
{
    public class GetAllAuctionHandler : IRequestHandler<GetAllAuctionQuery, IEnumerable<DisplayAllAuctionDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAuctionService _service;

        public GetAllAuctionHandler(IMapper mapper , IAuctionService service)
        {
            _mapper = mapper;
            _service = service;
        }
        public async Task<IEnumerable<DisplayAllAuctionDto>> Handle(GetAllAuctionQuery request, CancellationToken cancellationToken)
        {
            var Auctions = await _service.GetAll();
            return   _mapper.Map<IEnumerable<DisplayAllAuctionDto>>(Auctions);
        }
    }
}
