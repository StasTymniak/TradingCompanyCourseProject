using DAL.Interfaces;
using Domain;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{
    public class AuctionRepository : IRepository<Auction>
    {
        public string conn;
        public AuctionRepository(string _conn)
        {
            conn = _conn;
        }
        public Auction Create(Auction obj)
        {

            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                AuctionDTO auction = new AuctionDTO();
                db.Auctions.Add(auction.CreateMappToDTO(obj));
                db.SaveChanges();
            }
            return obj;
        }

        public void Delete(int id)
        {
        using (TradingCompanyContext db = new TradingCompanyContext(conn))
        {
            var auction = db.Auctions.Where(x => x.AuctionId == id).SingleOrDefault();
            if (auction != null)
            {
                db.Auctions.Remove(auction);
                db.SaveChanges();
            }
        }
        }

        public Domain.Auction Get(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                return db.Auctions.Find(id).MappFromDTO();
            }
        }

        public List<Auction> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                List<Auction> auctions = new List<Auction>();
                foreach (AuctionDTO item in db.Auctions.ToList())
                {
                    auctions.Add(item.MappFromDTO());
                }
                return auctions;
            }
        }

        public void Update(int id, Auction tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                AuctionDTO auction = db.Auctions.Where(x => x.AuctionId == id).SingleOrDefault();
                auction.UpdateMappToDTO(tmp);
                db.SaveChanges();
            }
        }
    }
}
