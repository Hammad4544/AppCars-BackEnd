using AppCar.Core.features.Auction.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Queries.Models
{
    public class GetAuctionByIdQuery : IRequest<DisplayAuctionById> 
    {
        public int Id { get; set; }
        public GetAuctionByIdQuery(int id) {
        
            Id = id;
        }

    }
}
