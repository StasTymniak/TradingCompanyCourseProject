using System.Collections.Generic;

using Domain;

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
