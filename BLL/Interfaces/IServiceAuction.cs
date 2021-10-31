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
        bool ActiveAuction(int id);
        bool DeactiveAuction(int id);
    }
}
