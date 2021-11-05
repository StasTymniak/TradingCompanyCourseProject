using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
