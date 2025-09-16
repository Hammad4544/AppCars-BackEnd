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
    public class GetActiveAuctionHandler : IRequestHandler<GetActiveAuctionQuery, IEnumerable<DisplayAllAuctionDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;

        public GetActiveAuctionHandler(IMapper mapper , IUnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;

        }
        public async Task<IEnumerable<DisplayAllAuctionDto>> Handle(GetActiveAuctionQuery request, CancellationToken cancellationToken)
        {
            var activeAuctions = await _unit.Auctions.GetActiveAuctionsAsync();
            var auctionDto = _mapper.Map<IEnumerable<DisplayAllAuctionDto>>(activeAuctions);
            return auctionDto;
        }
    }
}
