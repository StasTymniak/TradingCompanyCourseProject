using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAuction
    {
        List<Auction> GetAll();
        Auction Get(int id);
        Auction Create(Auction obj);
        void Update(int id, Auction obj);
        void Delete(int id);
    }
}
