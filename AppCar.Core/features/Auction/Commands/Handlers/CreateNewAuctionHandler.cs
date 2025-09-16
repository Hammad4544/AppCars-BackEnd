using AppCar.Core.features.Auction.Commands.Models;
using AppCar.Core.features.Auction.Dtos;
using AppCar.Data.Entities;
using AppCar.infrustrcture.UnitOfWork;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Commands.Handlers
{
    public class CreateNewAuctionHandler : IRequestHandler<AddNewAuctionQuery, CreateAuctionDto>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;

        public CreateNewAuctionHandler(IMapper mapper , IUnitOfWork unit)
        {
             _mapper = mapper;
            _unit = unit;
        }
        public async Task<CreateAuctionDto> Handle(AddNewAuctionQuery request, CancellationToken cancellationToken)
        {
            var newAuction = _mapper.Map<AppCar.Data.Entities.Auction>(request);
            var result = await  _unit.Auctions.AddNewAuction(newAuction);
            await _unit.SaveChangesAsync();
            var auctionDto = _mapper.Map<CreateAuctionDto>(newAuction);
            return auctionDto;
        }
    }
}
