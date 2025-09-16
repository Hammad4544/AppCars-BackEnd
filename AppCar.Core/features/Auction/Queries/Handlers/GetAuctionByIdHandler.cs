using AppCar.Core.features.Auction.Dtos;
using AppCar.Core.features.Auction.Queries.Models;
using AppCar.infrustrcture.UnitOfWork;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Queries.Handlers
{
    public class GetAuctionByIdHandler : IRequestHandler<GetAuctionByIdQuery, DisplayAuctionById>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;

        public GetAuctionByIdHandler(IMapper mapper , IUnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }
        public async Task<DisplayAuctionById> Handle(GetAuctionByIdQuery request, CancellationToken cancellationToken)
        {
            var auction = await _unit.Auctions.GetByIdAsync(request.Id);
            var auctionDto =  _mapper.Map<DisplayAuctionById>(auction);
            return auctionDto;
        }
    }
}
