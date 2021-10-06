using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAuctionDAL
    {
        List<AuctionDTO> GetAll();
        AuctionDTO Get(int id);
        void Create(AuctionDTO auction);
        void Update(int item, AuctionDTO auction);
        void Delete(int id);
    }
}
