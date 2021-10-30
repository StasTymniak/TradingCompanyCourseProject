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
        public List<Auction> GetAllAuctions();
        public List<Auction> GetAllActiveAuctions();
        public bool ActiveAuction(int id);
        public bool DeactiveAuction(int id);
    }
}
