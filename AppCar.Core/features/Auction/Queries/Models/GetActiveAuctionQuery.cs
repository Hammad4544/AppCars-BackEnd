using AppCar.Core.features.Auction.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Core.features.Auction.Queries.Models
{
    public class GetActiveAuctionQuery : IRequest<IEnumerable<DisplayAllAuctionDto>>
    {
    }
}
