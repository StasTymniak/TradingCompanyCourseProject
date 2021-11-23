using System;
using System.Collections.Generic;

using Domain;

namespace BLL.Services
{
    public interface IServiceAuction
    {
        List<Auction> GetAllAuctions();
        List<Auction> GetAllActiveAuctions();
        Auction ActiveAuction(int id);
        Auction DeactiveAuction(int id);
        Auction AddAuction(int productId, string auctionName, float startupPrice, float redemptionPrice, DateTime endtime);

    }
}
