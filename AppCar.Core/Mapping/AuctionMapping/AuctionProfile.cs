using AppCar.Core.features.Auction.Commands.Models;
using AppCar.Core.features.Auction.Dtos;
using AppCar.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.Mapping.AuctionMapping
{
    public class AuctionProfile : Profile
    {
        public AuctionProfile()
        {

            CreateMap<Auction, DisplayAllAuctionDto>()
                .ForMember(dest => dest.LOC, opt => opt.MapFrom(src => src.Location));
                      //src   --   dest
            CreateMap<Auction, DisplayAuctionById>();
            CreateMap<CreateAuctionDto, Auction>();
            CreateMap<Auction, CreateAuctionDto>();
            CreateMap<AddNewAuctionQuery, Auction>();

        }
    }
}
